using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayNameChangePet3 : MonoBehaviour
{
    public GameObject displayName;
    GameObject nameInput;
    InputField nameInputField;
    TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        nameInput = GameObject.Find("NameInputPet3");
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
        PlayerPrefs.SetString("pet3Name", nameInputField.text);
    }
}
