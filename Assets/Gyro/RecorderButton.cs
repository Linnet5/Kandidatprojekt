using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class RecorderButton : MonoBehaviour
{

    bool record;
    bool save;
    Color red;
    Color green;
    Color yellow;
    Color bluegray;
    float timeRemaining;
    float countdown;

    //List
    //private ArrayList arrayList;
    private List<Vector3> accelList;
    private List<Vector3> gyroList;
    private List<Vector3> meanAccelList;
    private List<Vector3> meanGyroList;
    Vector3 gyroSnapshot;
    GameObject recorder;
    GameObject analyzer;


    // Start is called before the first frame update
    void Start()
    {

        recorder = new GameObject("Recorder");
        recorder.AddComponent<FollowGyro>();
        recorder.AddComponent<FollowAccel>();
        analyzer = new GameObject("Analyzer");
        analyzer.AddComponent<Analyzer>();
        

        record = false;
        save = false;
        red = new Color(255, 0, 0);
        green = new Color(0, 255, 0);
        yellow = new Color(255,255,0);
        bluegray = new Color(200,200,255);

        GetComponent<Image>().color = bluegray;

        //Button
        GetComponent<Button>().onClick.AddListener(ButtonPressed);

        //Timer
        countdown = 3.4f;
        timeRemaining = countdown;

        //List
        accelList = new List<Vector3>();
        gyroList = new List<Vector3>();
        meanAccelList = new List<Vector3>();
        meanAccelList = new List<Vector3>();

    }

    // Update is called once per frame
    void Update()
    {
        if (record == true)
        {

            if (timeRemaining > 0)
            {
                accelList.Clear();
                gyroList.Clear();
                if (Mathf.RoundToInt(timeRemaining) > 2)
                {
                    GetComponent<Image>().color = green;
                }
                else
                {
                    GetComponent<Image>().color = yellow;
                }

                GameObject.Find("ButtonRecordText").GetComponent<Text>().text = Mathf.RoundToInt(timeRemaining).ToString();
                timeRemaining -= Time.deltaTime;

            }
            
            if (timeRemaining > 0.5f)
            {
                gyroSnapshot = GameObject.Find("Recorder").GetComponent<FollowGyro>().GetGyro();
            }

            else
            {

                GetComponent<Image>().color = red;
                GameObject.Find("ButtonRecordText").GetComponent<Text>().text = "RECORDING!";

                //RECORD ACCEL AND GYRO VECTORS
                Vector3 accelData = GameObject.Find("Recorder").GetComponent<FollowAccel>().GetAccel();
                accelList.Add(accelData);

                Vector3 gyroData = GameObject.Find("Recorder").GetComponent<FollowGyro>().GetGyro();
                gyroList.Add(gyroData-gyroSnapshot);
                //Debug.Log("GYRO: " + gyroData);
                //Debug.Log("GYRO KALI: " + (gyroData - gyroSnapshot));

                save = true;

            }


        }

        else {
            GetComponent<Image>().color = bluegray;
            GameObject.Find("ButtonRecordText").GetComponent<Text>().text = "Record";
            timeRemaining = countdown;

            if (save == true) {
                //SaveData(accelList, "accelData");
                //SaveData(gyroList, "gyroData");
                meanAccelList = analyzer.GetComponent<Analyzer>().GetMeans(accelList);
                meanGyroList = analyzer.GetComponent<Analyzer>().GetMeans(gyroList);
                //meanAccelList = accelList;
                //meanGyroList = gyroList;
                SaveData(meanAccelList, "meanAccelData");
                SaveData(meanGyroList, "meanGyroData");
                save = false;
            }

        }

        
    }

    private void SaveData(List<Vector3> list, string fileName) {
        string path = Application.persistentDataPath + "/" + fileName + ".txt";
        string lineOutput = "";

        for(int i = 0; i < list.Count; i++)
        {
            lineOutput += list[i].ToString() + "\n";
        }

        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(lineOutput);
    }

    public void ButtonPressed() {

        if (record == true)
        {
            record = false;
        }

        else
        {
            record = true;
        }
        
    }

}
