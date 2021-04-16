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
        nameInput = GameObject.Find("NameInputPet1");
        Debug.Log(nameInput);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeName()
    {
        nameInputField = nameInput.GetComponent<InputField>();
        txt = displayName.GetComponent<TextMeshProUGUI>();
        txt.SetText(nameInputField.text);
        PlayerPrefs.SetString("pet1Name", nameInputField.text);
        Debug.Log(PlayerPrefs.GetString("pet1Name"));
    }
}
