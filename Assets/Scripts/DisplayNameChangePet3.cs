using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayNameChangePet3 : MonoBehaviour
{
    public GameObject displayName;
    [SerializeField] GameObject nameInput;
    TMP_InputField nameInputField;
    TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeName()
    {
        nameInputField = nameInput.GetComponent<TMP_InputField>();
        txt = displayName.GetComponent<TextMeshProUGUI>();
        txt.SetText(nameInputField.text);
        PlayerPrefs.SetString("pet3Name", nameInputField.text);
    }
}
