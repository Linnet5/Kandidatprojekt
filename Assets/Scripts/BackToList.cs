using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToList : MonoBehaviour
{
    public GameObject petList;
    public GameObject pet1Inspect;
    public GameObject pet2Inspect;
    public GameObject pet3Inspect;
    public GameObject back;
    public GameObject pet1;
    public GameObject pet2;
    public GameObject pet3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToPetList() {
        pet1Inspect.SetActive(false);
        pet2Inspect.SetActive(false);
        pet3Inspect.SetActive(false);
        petList.SetActive(true);
        gameObject.SetActive(false);
        back.SetActive(true);

        if (bool.Parse(PlayerPrefs.GetString("pet1Unlocked")))
            pet1.GetComponent<Pet1>().DisplayName();
        if (bool.Parse(PlayerPrefs.GetString("pet2Unlocked")))
            pet2.GetComponent<Pet2>().DisplayName();
        if (bool.Parse(PlayerPrefs.GetString("pet3Unlocked")))
            pet3.GetComponent<Pet3>().DisplayName();
    }
}
