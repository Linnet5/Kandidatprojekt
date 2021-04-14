using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayNameChange : MonoBehaviour
{
    GameObject displayName;
    GameObject nameInput;
    // Start is called before the first frame update
    void Start()
    {
        displayName = GameObject.Find("Name");
        nameInput = GameObject.Find("NameInput");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeName()
    {

    }
 }
