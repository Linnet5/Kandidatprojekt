using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Analyzer : MonoBehaviour
{

    private bool result;
    private int standardNom = 100; //
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



    private void Start()
    {
        NomInputField = GameObject.Find("NomInputField");
        numberOfMeans = standardNom;
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
        samplesPerMeanF = input.Count / numberOfMeans;
        //samplesPerMean = input.Count / (float)numberOfMeans;
        int totalSamples = samplesPerMean * numberOfMeans;
        int kompIterations = totalSamples - input.Count;

        for (int i = 0; i < kompIterations; i++) {
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

    private void Analyze(List<Vector3> accel, List<Vector3> gyro, List<Vector3> referenceAccel, List<Vector3> referenceGyro) {

        meanAccel = CreateMeans(accel);
        meanGyro = CreateMeans(gyro);
        meanReferenceAccel = CreateMeans(referenceAccel);
        meanReferenceGyro = CreateMeans(referenceGyro);



    }

    public List<Vector3> GetMeans(List<Vector3> input) {
        
        return CreateMeans(input);

    }

    public int GetNom()
    {
        return numberOfMeans;
    }

    public bool GetResult() {
        return result;
    }

}
