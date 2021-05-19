using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectPet1 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet1Inspect;
    public GameObject backToList;
    public GameObject back;

    public Image buttonColor;
    // Start is called before the first frame update
    void Start()
    {
        petList = GameObject.Find("PetList");
    }

    // Update is called once per frame
    void Update()
    {
        if (bool.Parse(PlayerPrefs.GetString("pet1Chosen")))
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
        pet1Inspect.SetActive(true);
        pet1Inspect.GetComponent<Pet1>().DisplayName();
        pet1Inspect.GetComponent<Pet1>().DisplayInfo();
        backToList.SetActive(true);
        back.SetActive(false);
    }
}
