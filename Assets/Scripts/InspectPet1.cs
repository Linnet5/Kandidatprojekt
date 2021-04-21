using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectPet1 : MonoBehaviour
{
    GameObject petList;
    public GameObject pet1Inspect;
    // Start is called before the first frame update
    void Start()
    {
        petList = GameObject.Find("PetList");
        Debug.Log(pet1Inspect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InspectPet() {
        petList.SetActive(false);
        pet1Inspect.SetActive(true);
        pet1Inspect.GetComponent<Pet1>().DisplayName();
        pet1Inspect.GetComponent<Pet1>().DisplayInfo();
        Debug.Log(pet1Inspect.GetComponent<Pet1>().GetName());
    }
}
