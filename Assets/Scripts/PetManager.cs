using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

// Implement universal pet script for all pets, call member functions via pet manager. Pet manager does different things depending on scene.
// Make a scrollable list in unity, instantiate objects depending on unlocked status
public class PetManager : MonoBehaviour
{
    public GameObject pet1;
    public GameObject pet2;
    public GameObject pet3;
    public GameObject pet1Inspect;
    public GameObject pet2Inspect;
    public GameObject pet3Inspect;
    public GameObject backToList;
    public GameObject back;
    public GameObject pet1Button;
    public GameObject pet2Button;
    public GameObject pet3Button;

    // Start is called before the first frame update
    void Start()
    {
        backToList.SetActive(false);
        back.SetActive(true);
        // Setting default values for first time startup
        if (PlayerPrefs.GetString("pet1Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet1Name", "Pet 1");
            PlayerPrefs.SetInt("pet1Level", 1);
            PlayerPrefs.SetInt("pet1Xp", 0);
            PlayerPrefs.SetInt("pet1Atk", 5);
            PlayerPrefs.SetInt("pet1Def", 3);
            PlayerPrefs.SetInt("pet1Hp", 10);
            PlayerPrefs.SetInt("pet1Mp", 10);
            PlayerPrefs.SetString("pet1Chosen", "true");
            PlayerPrefs.SetString("pet1Unlocked", "true");
            PlayerPrefs.SetInt("pet1Id", 1);
        }
        if (PlayerPrefs.GetString("pet2Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet2Name", "Pet 2");
            PlayerPrefs.SetInt("pet2Level", 1);
            PlayerPrefs.SetInt("pet2Xp", 0);
            PlayerPrefs.SetInt("pet2Atk", 4);
            PlayerPrefs.SetInt("pet2Def", 5);
            PlayerPrefs.SetInt("pet2Hp", 25);
            PlayerPrefs.SetInt("pet2Mp", 3);
            PlayerPrefs.SetString("pet2Chosen", "false");
            PlayerPrefs.SetString("pet2Unlocked", "false");
            PlayerPrefs.SetInt("pet2Id", 2);
        }
        else if (PlayerPrefs.GetString("pet3Unlocked", "notUnlocked").Equals("notUnlocked")) {
            PlayerPrefs.SetString("pet3Name", "Pet 3");
            PlayerPrefs.SetInt("pet3Level", 1);
            PlayerPrefs.SetInt("pet3Xp", 0);
            PlayerPrefs.SetInt("pet3Atk", 9);
            PlayerPrefs.SetInt("pet3Def", 3);
            PlayerPrefs.SetInt("pet3Hp", 15);
            PlayerPrefs.SetInt("pet3Mp", 2);
            PlayerPrefs.SetString("pet3Chosen", "false");
            PlayerPrefs.SetString("pet3Unlocked", "false");
            PlayerPrefs.SetInt("pet3Id", 3);
        }

        // Enabling and displaying pet objects depending on unlocked status
        if (SceneManager.GetActiveScene().name == "Pet Menu")
        {
            pet1Inspect.SetActive(false);

            if (pet1.GetComponent<Pet1>().GetUnlocked()) {
                pet1.SetActive(true);                
                pet1.GetComponent<Pet1>().DisplayInfo();
                pet1.GetComponent<Pet1>().DisplayName();
                pet1Button.SetActive(true);
            }
            else {
                pet1.SetActive(false);
                pet1Button.SetActive(false);
            }
            if (!pet2.GetComponent<Pet2>().GetUnlocked()) {
                pet2.SetActive(true);                
                pet2.GetComponent<Pet2>().DisplayInfo();
                pet2.GetComponent<Pet2>().DisplayName();
                pet2Button.SetActive(true);
            }
            else {
                pet2.SetActive(false);
                pet2Button.SetActive(false);
            }
            if (!pet3.GetComponent<Pet3>().GetUnlocked()) {
                pet3.SetActive(true);                
                pet3.GetComponent<Pet3>().DisplayInfo();
                pet3.GetComponent<Pet3>().DisplayName();
                pet3Button.SetActive(true);
            }
            else {
                pet3.SetActive(false);
                pet3Button.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
