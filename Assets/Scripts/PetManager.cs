using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

// Implement universal pet script for all pets, call member functions via pet manager. Pet manager does different things depending on scene.
// Make a scrollable list in unity, instantiate objects depending on unlocked status
public class PetManager : MonoBehaviour
{
    List<GameObject> pets = new List<GameObject>();
    List<GameObject> availablePets = new List<GameObject>();
    public GameObject pet1;
    public GameObject pet2;
    public GameObject pet3;

    // Start is called before the first frame update
    void Start()
    {
        // Setting default values for first time startup
        if (PlayerPrefs.GetString("pet1Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet1Name", "Pet 1");
            PlayerPrefs.SetInt("pet1Level", 1);
            PlayerPrefs.SetInt("pet1Xp", 0);
            PlayerPrefs.SetString("pet1Chosen", "true");
            PlayerPrefs.SetString("pet1Unlocked", "true");
            PlayerPrefs.SetInt("pet1Id", 1);
        }
        if (PlayerPrefs.GetString("pet2Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet2Name", "Pet 2");
            PlayerPrefs.SetInt("pet2Level", 1);
            PlayerPrefs.SetInt("pet2Xp", 0);
            PlayerPrefs.SetString("pet2Chosen", "false");
            PlayerPrefs.SetString("pet2Unlocked", "false");
            PlayerPrefs.SetInt("pet2Id", 2);
        }
        else if (PlayerPrefs.GetString("pet3Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet3Name", "Pet 3");
            PlayerPrefs.SetInt("pet3Level", 1);
            PlayerPrefs.SetInt("pet3Xp", 0);
            PlayerPrefs.SetString("pet3Chosen", "false");
            PlayerPrefs.SetString("pet3Unlocked", "false");
            PlayerPrefs.SetInt("pet3Id", 3);
        }

        pets.Add(pet1);
        availablePets.Add(pet1);

        if (SceneManager.GetActiveScene().name == "Pet Menu")
        {
            foreach (GameObject pet in availablePets)
            {
                pet.GetComponent<Pet1>().DisplayInfo();
                pet.GetComponent<Pet1>().DisplayName();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
