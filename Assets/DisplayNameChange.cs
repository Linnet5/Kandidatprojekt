using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayNameChange : MonoBehaviour
{
    public GameObject displayName;
    GameObject nameInput;
    InputField nameInputField;
    TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(displayName);
        nameInput = GameObject.Find("NameInput");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeName()
    {
        nameInputField = nameInput.GetComponent<InputField>();
        txt = displayName.GetComponent<TextMeshProUGUI>();
        txt.SetText();
        Debug.Log(txt.text);
    }
 }
