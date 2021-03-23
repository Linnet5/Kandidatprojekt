using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecorderButton : MonoBehaviour
{

    bool record;
    Color red;
    Color green;
    Color yellow;
    Color bluegray;
    float timeRemaining;
    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        record = false;
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

        

    }

    // Update is called once per frame
    void Update()
    {

        if (record == true)
        {
            if (timeRemaining > 0)
            {
                if (Mathf.RoundToInt(timeRemaining) > 2)
                {
                    GetComponent<Image>().color = green;
                }
                else {
                    GetComponent<Image>().color = yellow;
                }
                
                GameObject.Find("ButtonText").GetComponent<Text>().text = Mathf.RoundToInt(timeRemaining).ToString();
                timeRemaining -= Time.deltaTime;

            }
            else {

                GetComponent<Image>().color = red;
                GameObject.Find("ButtonText").GetComponent<Text>().text = "RECORDING!";
                
            }
        }

        else {
            GetComponent<Image>().color = bluegray;
            GameObject.Find("ButtonText").GetComponent<Text>().text = "Record";
            timeRemaining = countdown;
        }
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

    public Quaternion RecordMotion() {

        Quaternion recordedmotion = new Quaternion();

        return recordedmotion;
    }
}
