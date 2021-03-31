using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Recording : MonoBehaviour
{
    bool record;
    bool save;
    float timeRemaining;
    float countdown;
    private List<float> y_pos_test;
    private List<float> y_pos_ideal;
    GameObject test;
    GameObject ideal;

    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("AccTest");
        ideal = GameObject.Find("Ideal");
        GetComponent<Button>().onClick.AddListener(ButtonPressed);
        record = false;
        save = false;
        countdown = 3.4f;
        timeRemaining = countdown;
        y_pos_test = new List<float>(); 
        y_pos_ideal = new List<float>();
        Debug.Log(Application.persistentDataPath);

    }

    // Update is called once per frame
    void Update()
    {
        if (record)
        {
            if (timeRemaining > 0)
            {
                y_pos_test.Clear();
                y_pos_ideal.Clear();
                GameObject.Find("Text").GetComponent<Text>().text = Mathf.RoundToInt(timeRemaining).ToString();
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                GameObject.Find("Text").GetComponent<Text>().text = "RECORDING!";
                float y_pos_data_test = GameObject.Find("AccTest").transform.position.y;
                float y_pos_data_ideal = GameObject.Find("Ideal").transform.position.y;
                y_pos_test.Add(y_pos_data_test);
                y_pos_ideal.Add(y_pos_data_ideal);
                save = true;
            }
        }
        else
        {
            GameObject.Find("Text").GetComponent<Text>().text = "Record";
            timeRemaining = countdown;
            if (save)
            {
                SaveData(y_pos_test, "Test");
                SaveData(y_pos_ideal, "Ideal");
                save = false;
            }
        }
    }

    private void SaveData(List<float> list, string fileName)
    {
        int counter = 0;
        string path = Application.persistentDataPath + "/" + fileName + counter.ToString() + ".txt";
        while (System.IO.File.Exists(path))
        {
            counter++;
            path = Application.persistentDataPath + "/" + fileName + counter.ToString() + ".txt";
        }


        string lineOutput = "";

        for (int i = 0; i < list.Count; i++)
        {
            lineOutput += list[i].ToString("F9") + "\n";
        }

        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(lineOutput);
        writer.Flush();
        writer.Close();
    }

    public void ButtonPressed()
    {

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

