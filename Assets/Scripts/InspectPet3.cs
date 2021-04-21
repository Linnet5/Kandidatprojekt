using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectPet3 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet3Inspect;
    // Start is called before the first frame update
    void Start()
    {
        petList = GameObject.Find("PetList");
        Debug.Log(pet3Inspect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InspectPet() {
        petList.SetActive(false);
        pet3Inspect.SetActive(true);
        pet3Inspect.GetComponent<Pet3>().DisplayName();
        pet3Inspect.GetComponent<Pet3>().DisplayInfo();
    }
}
