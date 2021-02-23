using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = thisButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
