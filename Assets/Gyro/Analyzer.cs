using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyzer : MonoBehaviour
{

    private bool result;
    private int numberOfMeans = 5; //FIXA I UI
    int samplesPerMean;
    private List<Vector3> referenceAccel;
    private List<Vector3> referenceGyro;
    private List<Vector3> meanReferenceAccel;
    private List<Vector3> meanReferenceGyro;
    private List<Vector3> meanAccel;
    private List<Vector3> meanGyro;
    Vector3 inputSum = Vector3.zero;
    private float floatConversion;
    

    private List<Vector3> CreateMeans(List<Vector3> input)
    {

        List<Vector3> output = new List<Vector3>();

        samplesPerMean = Mathf.FloorToInt(input.Count / numberOfMeans);
        
        for(int i = 0; i < numberOfMeans; i++)
        {
            for (int j = i*samplesPerMean; j < (i+1)*samplesPerMean; j++)
            {
                inputSum += input[j];
            }
            floatConversion = (float)samplesPerMean;
            output.Add(inputSum / samplesPerMean);
            
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

    public bool GetResult() {
        return result;
    }

}
