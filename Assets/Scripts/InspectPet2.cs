using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectPet2 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet2Inspect;

    public GameObject backToList;
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        petList = GameObject.Find("PetList");
    }

    // Update is called once per frame
    void Update()
    {
        
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
