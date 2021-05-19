using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public Button pet1ActivateButton;
    public Button pet2ActivateButton;
    public Button pet3ActivateButton;

    private void Awake()
    {
        pet1.SetActive(true);
        pet1Button.SetActive(true);

        pet2.SetActive(false);
        pet2Button.SetActive(false);

        pet3.SetActive(false);
        pet3Button.SetActive(false);

        //RESET TO DEFAULT PLAYERPREFS IF UNCOMMENTED

        //PlayerPrefs.SetString("pet2Unlocked", "false");
        //PlayerPrefs.SetString("pet3Unlocked", "false");

        //PlayerPrefs.SetString("pet1FirstTimeUnlock", "true");
        //PlayerPrefs.SetString("pet2FirstTimeUnlock", "true");
        //PlayerPrefs.SetString("pet3FirstTimeUnlock", "true");

        //RESET TO DEFAULT PLAYERPREFS IF UNCOMMENTED


        // First time startup check
        if (PlayerPrefs.GetString("pet2Unlocked", "NotSet").Equals("NotSet"))
        {
            PlayerPrefs.SetString("pet2Unlocked", "false");
        }

        if (PlayerPrefs.GetString("pet3Unlocked", "NotSet").Equals("NotSet"))
        {
            PlayerPrefs.SetString("pet3Unlocked", "false");
        }
        
        if (bool.Parse(PlayerPrefs.GetString("pet1FirstTimeUnlock", "false")))
        {
            Debug.Log(PlayerPrefs.GetString("pet1FirstTimeUnlock"));
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
            PlayerPrefs.SetString("pet1Upgraded", "false");
            PlayerPrefs.SetString("pet1FirstTimeUnlock", "false");
        }
        if (bool.Parse(PlayerPrefs.GetString("pet2FirstTimeUnlock", "false")))
        {
            PlayerPrefs.SetString("pet2Name", "Pet 2");
            PlayerPrefs.SetInt("pet2Level", 1);
            PlayerPrefs.SetInt("pet2Xp", 0);
            PlayerPrefs.SetInt("pet2Atk", 4);
            PlayerPrefs.SetInt("pet2Def", 5);
            PlayerPrefs.SetInt("pet2Hp", 25);
            PlayerPrefs.SetInt("pet2Mp", 3);
            PlayerPrefs.SetString("pet2Chosen", "false");
            PlayerPrefs.SetString("pet2Unlocked", "true");
            PlayerPrefs.SetInt("pet2Id", 2);
            PlayerPrefs.SetString("pet2Upgraded", "false");
            PlayerPrefs.SetString("pet2FirstTimeUnlock", "false");
        }
        if (bool.Parse(PlayerPrefs.GetString("pet3FirstTimeUnlock", "false")))
        {
            PlayerPrefs.SetString("pet3Name", "Pet 3");
            PlayerPrefs.SetInt("pet3Level", 1);
            PlayerPrefs.SetInt("pet3Xp", 0);
            PlayerPrefs.SetInt("pet3Atk", 9);
            PlayerPrefs.SetInt("pet3Def", 3);
            PlayerPrefs.SetInt("pet3Hp", 15);
            PlayerPrefs.SetInt("pet3Mp", 2);
            PlayerPrefs.SetString("pet3Chosen", "false");
            PlayerPrefs.SetString("pet3Unlocked", "true");
            PlayerPrefs.SetInt("pet3Id", 3);
            PlayerPrefs.SetString("pet3Upgraded", "false");
            PlayerPrefs.SetString("pet3FirstTimeUnlock", "false");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        backToList.SetActive(false);
        back.SetActive(true);
        // Setting default values for first time startup
       

        // Enabling and displaying pet objects depending on unlocked status

        if (bool.Parse(PlayerPrefs.GetString("pet1Unlocked"))) {
            pet1.SetActive(true);                
            pet1Button.SetActive(true);
            pet1.GetComponent<Pet1>().DisplayInfo();
            pet1.GetComponent<Pet1>().DisplayName();
        }

        if (bool.Parse(PlayerPrefs.GetString("pet2Unlocked"))) {
        Debug.Log("hej");
            pet2.SetActive(true);                
            pet2Button.SetActive(true);
            pet2.GetComponent<Pet2>().DisplayInfo();
            pet2.GetComponent<Pet2>().DisplayName();
        }

        if (bool.Parse(PlayerPrefs.GetString("pet3Unlocked"))) {
            pet3.SetActive(true);                
            pet3Button.SetActive(true);
            pet3.GetComponent<Pet3>().DisplayInfo();
            pet3.GetComponent<Pet3>().DisplayName();
        }
    }

    public void ActivatePet1()
    {
        Debug.Log("Pet1 activated");
        PlayerPrefs.SetString("pet1Chosen", "true");
        PlayerPrefs.SetString("pet2Chosen", "false");
        PlayerPrefs.SetString("pet3Chosen", "false");
    }

    public void ActivatePet2()
    {
        PlayerPrefs.SetString("pet1Chosen", "false");
        PlayerPrefs.SetString("pet2Chosen", "true");
        PlayerPrefs.SetString("pet3Chosen", "false");
    }

    public void ActivatePet3()
    {
        PlayerPrefs.SetString("pet1Chosen", "false");
        PlayerPrefs.SetString("pet2Chosen", "false");
        PlayerPrefs.SetString("pet3Chosen", "true");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (bool.Parse(PlayerPrefs.GetString("pet1Chosen")))
        {
            pet1ActivateButton.interactable = false;
        }
        else
        {
            pet1ActivateButton.interactable = true;
        }

        if(bool.Parse(PlayerPrefs.GetString("pet2Unlocked")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet2Chosen")))
            {
                pet2ActivateButton.interactable = false;
            }
            else
            {
                pet2ActivateButton.interactable = true;
            }
        }

        if (bool.Parse(PlayerPrefs.GetString("pet3Unlocked")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet3Chosen")))
            {
                pet3ActivateButton.interactable = false;
            }
            else
            {
                pet3ActivateButton.interactable = true;
            }
        }
    }
}
