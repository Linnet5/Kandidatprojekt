using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectPet2 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet2Inspect;

    public GameObject backToList;
    public GameObject back;
    // Start is called before the first frame update

    public Image buttonColor;
    void Start()
    {
        petList = GameObject.Find("PetList");
    }

    // Update is called once per frame
    void Update()
    {
        if (bool.Parse(PlayerPrefs.GetString("pet2Chosen")))
        {
            //Cyan
            buttonColor.color = new Color32(0, 255, 221, 255);
        }
        else
        {
            //White
            buttonColor.color = new Color32(255, 255, 255, 255);
        }
    }

    public void InspectPet() {
        petList.SetActive(false);
        pet2Inspect.SetActive(true);
        pet2Inspect.GetComponent<Pet2>().DisplayName();
        pet2Inspect.GetComponent<Pet2>().DisplayInfo();
        backToList.SetActive(true);
        back.SetActive(false);
    }
}
