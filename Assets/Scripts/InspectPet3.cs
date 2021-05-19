using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectPet3 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet3Inspect;
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
        if (bool.Parse(PlayerPrefs.GetString("pet3Chosen")))
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
        pet3Inspect.SetActive(true);
        pet3Inspect.GetComponent<Pet3>().DisplayName();
        pet3Inspect.GetComponent<Pet3>().DisplayInfo();
        backToList.SetActive(true);
        back.SetActive(false);
    }
}
