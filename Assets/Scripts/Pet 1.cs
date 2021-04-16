using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Pet1 : MonoBehaviour
{
    private string petName;
    private int level;
    private int xp;
    private bool chosen;
    private bool unlocked;
    private int id;
    GameObject pet1;
    // Start is called before the first frame update
    void Start()
    {
        petName = PlayerPrefs.GetString("pet1Name");
        level = PlayerPrefs.GetInt("pet1Level");
        xp = PlayerPrefs.GetInt("pet1Xp");
        chosen = bool.Parse(PlayerPrefs.GetString("pet1Chosen"));
        unlocked = bool.Parse(PlayerPrefs.GetString("pet1Unlocked"));
        id = PlayerPrefs.GetInt("pet1Id");
        
        if (unlocked)
        {
            pet1.GetComponent<RawImage>().enabled = true;
        }
        else
        {
            pet1.GetComponent<RawImage>().enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Unlock() {
        PlayerPrefs.SetString("pet1Name", "Pet 1");
        PlayerPrefs.SetInt("pet1Level", 1);
        PlayerPrefs.SetInt("pet1Xp", 0);
        PlayerPrefs.SetString("pet1Chosen", "true");
        PlayerPrefs.SetString("pet1Unlocked", "true");
        PlayerPrefs.SetInt("pet1Id", 1);
    }

    void ChangeName (string name) {
        PlayerPrefs.SetString("pet1Name", name);
    }

    void IncreaseLevel() {
        PlayerPrefs.SetInt("pet1Level", level + 1);
    }

    void IncreaseXp(int addedXp) {
        xp += addedXp;
        if (xp >= 100) {
            xp -= 100;
            IncreaseLevel();
        }
    }

}
