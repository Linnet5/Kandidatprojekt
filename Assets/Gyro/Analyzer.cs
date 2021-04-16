using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Globalization;


public class Analyzer : MonoBehaviour
{

    private bool result;
    private int standardNom = 100; 
    private int numberOfMeans;
    int samplesPerMean;
    float samplesPerMeanF;
    private List<Vector3> referenceAccel;
    private List<Vector3> referenceGyro;
    private List<Vector3> meanReferenceAccel;
    private List<Vector3> meanReferenceGyro;
    private List<Vector3> meanAccel;
    private List<Vector3> meanGyro;
    Vector3 inputSum;
    private float floatConversion;
    private GameObject NomInputField;


    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        NomInputField = GameObject.Find("NomInputField");
        numberOfMeans = standardNom;

        meanReferenceAccel = new List<Vector3>();
        meanReferenceGyro = new List<Vector3>();

        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //Read TextAssets with two loops
        string filePath = "Assets/Resources/Reference Moves/Squat/";
        TextAsset gyro = Resources.Load("Reference Moves/Squat/meanReferenceGyro.txt") as TextAsset;
        TextAsset accel = Resources.Load("Reference Moves/Squat/meanReferenceAccel.txt") as TextAsset;
        
        string[] vectorString;
        StreamReader srGyro = new StreamReader(gyro);
        StreamReader srAccel = new StreamReader(accelFileName);
        //string txtGyro = srGyro.ReadLine();
        
        //string txtAccel = srAccel.ReadLine();

        
        while (txtGyro != null)
        {


            vectorString = txtGyro.Split(' ');

            meanReferenceGyro.Add(new Vector3(float.Parse(vectorString[0], CultureInfo.InvariantCulture), float.Parse(vectorString[1], CultureInfo.InvariantCulture), float.Parse(vectorString[2], CultureInfo.InvariantCulture)));
            txtGyro = srGyro.ReadLine();

        }

        while (txtAccel != null)
        {

            vectorString = txtAccel.Split(' ');

            meanReferenceAccel.Add(new Vector3(float.Parse(vectorString[0], CultureInfo.InvariantCulture), float.Parse(vectorString[1], CultureInfo.InvariantCulture), float.Parse(vectorString[2], CultureInfo.InvariantCulture)));
            txtAccel = srAccel.ReadLine();

        }

    }

    private List<Vector3> CreateMeans(List<Vector3> input)
    {
        if (!(NomInputField.GetComponent<InputField>().text == ""))
        {
            numberOfMeans = int.Parse(NomInputField.GetComponent<InputField>().text);
        }

        else {
            numberOfMeans = standardNom;
        }

        //Debug.Log(numberOfMeans);

        
        List<Vector3> output = new List<Vector3>();

        
        samplesPerMean = Mathf.CeilToInt(input.Count / numberOfMeans);
        //samplesPerMeanF = input.Count / numberOfMeans;
        //samplesPerMean = input.Count / (float)numberOfMeans;
        int totalSamples = samplesPerMean * numberOfMeans;
        int kompIterations = totalSamples - input.Count;

        for (int i = 0; i < kompIterations; i++)
        {
            input.Add(Vector3.zero);
        }


        for (int i = 0; i < numberOfMeans; i++)
        {
            inputSum = Vector3.zero;
            for (int j = i * samplesPerMean; j < (i + 1) * samplesPerMean; j++)
            {
                inputSum = inputSum + input[j];
            }
            floatConversion = (float)samplesPerMean;
            output.Add(inputSum / floatConversion);
            //Debug.Log((inputSum/floatConversion).ToString("F9"));
        }



        return output;
    }

    private bool Analyze(List<Vector3> accel, List<Vector3> gyro) {

        meanAccel = CreateMeans(accel);
        meanGyro = CreateMeans(gyro);

        Vector3 deltaAccel = Vector3.zero;
        Vector3 deltaGyro = Vector3.zero;

        for (int i = 0; i < meanReferenceAccel.Count; i++)
        {
            deltaAccel += (meanReferenceAccel[i] - meanAccel[i]);
        }
        deltaAccel /= meanReferenceAccel.Count;

        for (int i = 0; i < meanReferenceGyro.Count; i++) {
            //deltaGyro += (meanReferenceGyro[i] - new Vector3(Mathf.Abs(meanAccel[i].x), Mathf.Abs(meanAccel[i].y), Mathf.Abs(meanAccel[i].z)));
            deltaGyro.x += Mathf.Abs(meanReferenceGyro[i].x - Mathf.Abs(meanAccel[i].x));
            deltaGyro.y += Mathf.Abs(meanReferenceGyro[i].y - Mathf.Abs(meanAccel[i].y));
            deltaGyro.z += Mathf.Abs(meanReferenceGyro[i].z - Mathf.Abs(meanAccel[i].z));
        }
        deltaGyro /= (float)(meanReferenceGyro.Count);

        if (deltaGyro.y < 0.13f)
        {
            GameObject.Find("VerificationText").GetComponent<Text>().text = "YOU�RE AWESOME! :)))\n" + "dE: " + deltaGyro.y.ToString();
            GameObject.Find("VerificationText").GetComponent<Text>().color = Color.green;
            Debug.Log("YOU MADE IT");
            Debug.Log(deltaGyro.y);
            return true;
        }

        else {
            GameObject.Find("VerificationText").GetComponent<Text>().text = "YOU SUCK! :(((\n" + "dE: " + deltaGyro.y.ToString();
            GameObject.Find("VerificationText").GetComponent<Text>().color = Color.red;
            Debug.Log("YOU FAILED");
        }
        Debug.Log(deltaGyro.y);

        return false;
    }

    public List<Vector3> GetMeans(List<Vector3> input) {
        
        return CreateMeans(input);

    }

    public int GetNom()
    {
        return numberOfMeans;
    }

    public bool GetResult(List<Vector3> accel, List<Vector3> gyro) {
        return Analyze(accel, gyro);
    }

}
