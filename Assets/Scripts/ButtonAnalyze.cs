using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnalyze : MonoBehaviour
{

    private bool analyze = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        if (analyze)
        {

        }
        else 
        {
            
        }
    }

    public void ButtonPressed()
    {

        if (analyze == true)
        {
            analyze = false;
        }

        else
        {
            analyze = true;
        }

    }
}
