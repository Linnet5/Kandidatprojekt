using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Globalization;


public class Analyzer : MonoBehaviour
{

    private bool result;
    private int standardNom = 50; 
    private int numberOfMeans;
    int samplesPerMean;
    float samplesPerMeanF;

    List<Vector3> accelBuffer;
    List<Vector3> gyroBuffer;

    private List<Vector3> referenceAccel;
    private List<Vector3> referenceGyro;
    private List<Vector3> meanReferenceAccel;
    private List<Vector3> meanReferenceGyro;
    private List<Vector3> meanAccel;
    private List<Vector3> meanGyro;
    Vector3 inputSum;
    private float floatConversion;
    private GameObject NomInputField;
    bool movement = false;
    bool record = false;


    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        NomInputField = GameObject.Find("NomInputField");
        numberOfMeans = standardNom;

        accelBuffer = new List<Vector3>();
        gyroBuffer = new List<Vector3>();

        for (int i = 0; i < 325; i++) {
            accelBuffer.Add(Vector3.zero);
            gyroBuffer.Add(Vector3.zero);
        }

        meanReferenceAccel = new List<Vector3>();
        meanReferenceGyro = new List<Vector3>();

        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //Read TextAssets with two loops
        //string filePath = "Assets/Resources/Reference Moves/Squat/";
        TextAsset gyro = Resources.Load("Reference Moves/Backlift/meanReferenceGyro") as TextAsset;
        //TextAsset accel = Resources.Load("Reference Moves/Backlift/meanReferenceAccel") as TextAsset;

        string[] lines = gyro.text.Split('\n');
        string[] vectorString;

        for (int i = 0; i < lines.Length; i++)
        {

            vectorString = lines[i].Split(' ');

            meanReferenceGyro.Add(new Vector3(float.Parse(vectorString[0], CultureInfo.InvariantCulture), float.Parse(vectorString[1], CultureInfo.InvariantCulture), float.Parse(vectorString[2], CultureInfo.InvariantCulture)));
        }


    }

    private void Update()
    {
        //REMOVE AT 5*65-1???? @Elin
        accelBuffer.RemoveAt(324);
        accelBuffer.Insert(0, Input.gyro.userAcceleration);

        gyroBuffer.RemoveAt(324);
        gyroBuffer.Insert(0, Input.gyro.gravity);
        //Debug.Log(gyroBuffer.Count);
    }

    private List<Vector3> CreateMeans(List<Vector3> input)
    {
        //if (!(NomInputField.GetComponent<InputField>().text == ""))
        //{
        //    numberOfMeans = int.Parse(NomInputField.GetComponent<InputField>().text);
        //}

        //else {
        //    numberOfMeans = standardNom;
        //}

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
                //Debug.Log("Inputsum  " + inputSum);
            }
            floatConversion = (float)samplesPerMean;
            //Debug.Log("floatConversion  " + floatConversion);
            output.Add(inputSum / floatConversion);
            //Debug.Log("output  " + output);
            //Debug.Log(" InputSum/floatAnalyz    "+(inputSum/floatConversion).ToString("F9"));
        }



        return output;
    }

    
    private float Analyze(List<Vector3> accel, List<Vector3> gyro) {
        
       //for (int i = 0; i < gyro.Count; i++)
       //{
       //    Debug.Log("GyroList  " + gyro[i].ToString("F4"));
       //}

        meanAccel = CreateMeans(accel);
        meanGyro = CreateMeans(gyro);

        for (int i = 0; i < meanGyro.Count; i++)
        {
            Debug.Log("GyroList  " + meanGyro[i].ToString("F4"));
        }

        Vector3 deltaAccel = Vector3.zero;
        Vector3 deltaGyro = Vector3.zero;

        float xMax = Mathf.Epsilon;
        float yMax = Mathf.Epsilon;
        float zMax = Mathf.Epsilon;

        for (int i = 0; i < meanGyro.Count; i++)
        {
            
            if (Mathf.Abs(meanGyro[i].x) > xMax)
            {
                xMax = Mathf.Abs(meanGyro[i].x);
            }

            if (Mathf.Abs(meanGyro[i].y) > yMax)
            {
                yMax = Mathf.Abs(meanGyro[i].y);
            }

            if (Mathf.Abs(meanGyro[i].z) > zMax)
            {
                zMax = Mathf.Abs(meanGyro[i].z);
            }
        }
        //Debug.Log("xMax = " + xMax);
        for (int i = 0; i < meanReferenceAccel.Count; i++)
        {
            deltaAccel += (meanReferenceAccel[i] - meanAccel[i]);
        }
        deltaAccel /= meanReferenceAccel.Count;

        for (int i = 0; i < meanReferenceGyro.Count; i++) {
            //deltaGyro += (meanReferenceGyro[i] - new Vector3(Mathf.Abs(meanAccel[i].x), Mathf.Abs(meanAccel[i].y), Mathf.Abs(meanAccel[i].z)));
            deltaGyro.x += Mathf.Abs(meanReferenceGyro[i].x - (meanGyro[i].x / xMax));
            deltaGyro.y += Mathf.Abs(meanReferenceGyro[i].y - (meanGyro[i].y / yMax));
            deltaGyro.z += Mathf.Abs(meanReferenceGyro[i].z - (meanGyro[i].z / zMax));
            //Debug.Log("meanGyro/xMax  " + (meanGyro[i].x / xMax));
            //Debug.Log("meanGyro  " + meanGyro[i].x);
        }
        deltaGyro /= (float)(meanReferenceGyro.Count);
        
        
        //@elin ska vi inte jämföra x nu? Kanske ska va y
        return deltaGyro.x;

    }

    public List<Vector3> GetMeans(List<Vector3> input) {
        
        return CreateMeans(input);

    }

    public int GetNom()
    {
        return numberOfMeans;
    }

    public float GetResult() {


        /* @Elin Behöver ändra siffrorna här
        delta = 0.1251 //godkänd kanske 0.15
           result =  0.85 = 1 - 0.15;
        result = result -  
        */
        //Debug.Log("Analys buffert "+ Analyze(accelBuffer, gyroBuffer));

        float result = 0;
        
        result = 1 - Analyze(accelBuffer,gyroBuffer);
        
        //result -= 0.2f;
        //result *= 1.45f;

        //accelBuffer = new List<Vector3>();
        //gyroBuffer = new List<Vector3>();

        //for (int i = 0; i < 130; i++)
        //{
        //    accelBuffer.Add(Vector3.zero);
        //    gyroBuffer.Add(Vector3.zero);
        //}

        return result;
    }

}
