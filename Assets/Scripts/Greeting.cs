using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Greeting : MonoBehaviour
{
    private GameObject greetingText;
    // Start is called before the first frame update
    void Start()
    {
        int sysHour = System.DateTime.Now.Hour;
        Debug.Log(gameObject);
        
        greetingText = gameObject;

        if(sysHour > 17)
        {
            greetingText.GetComponent<TextMeshProUGUI>().SetText("Good evening");
        }

        else if(sysHour < 10)
        {
            greetingText.GetComponent<TextMeshProUGUI>().SetText("Good morning");
        }

        else
        {
            greetingText.GetComponent<TextMeshProUGUI>().SetText("Good day");
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
