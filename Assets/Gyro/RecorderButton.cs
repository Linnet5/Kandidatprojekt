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
    GameObject nameInputField;
    GameObject nomInputField;
    private int nomInput;
    int frameCounter = 0;
    int stageLength;
    int frame;

    AudioSource audioData;
    bool Up_Play = false;
    bool Down_Play = false;
    bool Right_Play = false;
    bool Left_Play = false;
    bool Middle_Play = false;



    // Start is called before the first frame update
    void Start()
    {

        recorder = new GameObject("Recorder");
        recorder.AddComponent<FollowGyro>();
        recorder.AddComponent<FollowAccel>();
        analyzer = new GameObject("Analyzer");
        analyzer.AddComponent<Analyzer>();
        nameInputField = GameObject.Find("NameInputField");
        

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

        stageLength = 65;
        frame = stageLength * 5;

        //List
        accelList = new List<Vector3>();
        gyroList = new List<Vector3>();
        meanAccelList = new List<Vector3>();
        meanAccelList = new List<Vector3>();

        //File counter
        
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
                //Vector3 accelData = GameObject.Find("Recorder").GetComponent<FollowAccel>().GetAccel();
                Vector3 accelData = Input.gyro.userAcceleration;
                accelList.Add(accelData);

                //Vector3 gyroData = GameObject.Find("Recorder").GetComponent<FollowGyro>().GetGyro();
                //gyroList.Add(gyroData-gyroSnapshot);
                Vector3 gyroData = Input.gyro.gravity;
                gyroList.Add(gyroData);


                //Vector3 gravity = new Vector3(0.0f,-1.0f,0.0f);
                //float angle = (Vector3.Dot(gyroData,gravity))/(gravity.magnitude*gyroData.magnitude);
                //Debug.Log(angle);
                //Debug.Log("GYRO: " + gyroData);
                //Debug.Log("GYRO KALI: " + (gyroData - gyroSnapshot));

                if (Up_Play == false)
                {
                    GameObject.Find("Up").GetComponent<AudioSource>().Play(0);
                    Up_Play = true;
                }


                if (frameCounter > stageLength)
                {
                    //Up
                    //Debug.Log("Up!");
                   
                    if (Right_Play == false)
                    {
                        GameObject.Find("Right").GetComponent<AudioSource>().Play(0);
                        Right_Play = true;
                    }
                
                    
                }

                if (frameCounter > stageLength*2)
                {
                    //Up
                    //Debug.Log("Up!");

                    if (Left_Play == false)
                    {
                        GameObject.Find("Left").GetComponent<AudioSource>().Play(0);
                        Left_Play = true;
                    }


                }

                if (frameCounter > stageLength * 3)
                {
                    //Up
                    //Debug.Log("Up!");

                    if (Middle_Play == false)
                    {
                        GameObject.Find("Middle").GetComponent<AudioSource>().Play(0);
                        Middle_Play = true;
                    }


                }

                if (frameCounter > stageLength * 4)
                {
                    //Up
                    //Debug.Log("Up!");

                    if (Down_Play == false)
                    {
                        GameObject.Find("Down").GetComponent<AudioSource>().Play(0);
                        Down_Play = true;
                    }


                }

                save = true;
                frameCounter++;
                

                if (frameCounter > frame)
                {
                    frameCounter = 0;
                    record = false;
                    Up_Play = false;
                    Down_Play = false;
                    Right_Play = false;
                    Left_Play = false;
                    Middle_Play = false;
                }
                
            }


        }

        else {
            GetComponent<Image>().color = bluegray;
            GameObject.Find("ButtonRecordText").GetComponent<Text>().text = "Record";
            timeRemaining = countdown;

            //ADD NAME INPUT
            string nameInput = nameInputField.GetComponent<InputField>().text;
            

            if (save == true) {
                meanAccelList = analyzer.GetComponent<Analyzer>().GetMeans(accelList);
                meanGyroList = analyzer.GetComponent<Analyzer>().GetMeans(gyroList);
                nomInput = analyzer.GetComponent<Analyzer>().GetNom();
                SaveData(accelList, nameInput + "-" + nomInput + "accelList-");
                SaveData(gyroList, nameInput + "-" + nomInput + "gyroList-");
                SaveData(meanAccelList, nameInput + "-" + nomInput + "meanAccelList-");
                SaveData(meanGyroList, nameInput + "-" + nomInput + "meanGyroList-");


                //float result = analyzer.GetComponent<Analyzer>().GetResult();

                //if (result >= 0.75f)
                //{
                //    GameObject.Find("VerificationText").GetComponent<Text>().text = "PERFECT! :DDD\n" + "dE: " + result;
                //    GameObject.Find("VerificationText").GetComponent<Text>().color = Color.green;
                //    Debug.Log("YOU MADE IT");
                //    Debug.Log(result);
                //}

                //else if (result > 0.70f)
                //{
                //    GameObject.Find("VerificationText").GetComponent<Text>().text = "GREAT! :)))\n" + "dE: " + result;
                //    GameObject.Find("VerificationText").GetComponent<Text>().color = Color.white;
                //    Debug.Log("YOU MADE IT");
                //    Debug.Log(result);
                //}

                //else if (result > 0.65f)
                //{
                //    GameObject.Find("VerificationText").GetComponent<Text>().text = "GOOD! :)\n" + "dE: " + result;
                //    GameObject.Find("VerificationText").GetComponent<Text>().color = Color.yellow;
                //    Debug.Log("YOU MADE IT");
                //    Debug.Log(result);
                //}

                //else
                //{
                //    GameObject.Find("VerificationText").GetComponent<Text>().text = "MISS! :(((\n" + "dE: " + result;
                //    GameObject.Find("VerificationText").GetComponent<Text>().color = Color.red;
                //    Debug.Log("YOU FAILED");
                //}

                //Debug.Log(result);



                save = false;
            }

        }
       

    }

    private void SaveData(List<Vector3> list, string fileName) {
        int counter = 0;
        string path = Application.persistentDataPath + "/" + fileName + counter.ToString() + ".txt";
        while (System.IO.File.Exists(path))
        {
            counter++;
            path = Application.persistentDataPath + "/" + fileName + counter.ToString() + ".txt";
        }

        
        string lineOutput = "";

        for(int i = 0; i < list.Count; i++)
        {
            lineOutput += list[i].ToString("F9") + "\n";
        }

        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(lineOutput);
        writer.Flush();
        writer.Close();
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
