using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
public class Pet3 : MonoBehaviour
{
    private string petName;
    private int level;
    private int xp;
    private bool chosen;
    private bool unlocked;
    private int id;
    GameObject pet3;
    GameObject pet3Name;
    GameObject pet3Level;
    GameObject pet3Xp;
    UnityEngine.UI.RawImage pet3Image;
    GameObject petList;
    GameObject pet3Inspect;
    // Start is called before the first frame update
    void Awake()
    {
        // Find game objects attached to pet
        pet3 = GameObject.Find("Pet 3");
        pet3Name = transform.Find("NamePet3").gameObject;
        pet3Level = transform.Find("LevelPet3").gameObject;
        pet3Xp = transform.Find("XpPet3").gameObject;
        pet3Image = pet3.GetComponent<RawImage>();
        petList = GameObject.Find("PetList");

        // Set private variables
        petName = PlayerPrefs.GetString("pet3Name");
        level = PlayerPrefs.GetInt("pet3Level");
        xp = PlayerPrefs.GetInt("pet3Xp");
        chosen = bool.Parse(PlayerPrefs.GetString("pet3Chosen"));
        unlocked = bool.Parse(PlayerPrefs.GetString("pet3Unlocked"));
        id = PlayerPrefs.GetInt("pet3Id");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayName()
    {
        TextMeshProUGUI txt = pet3Name.GetComponent<TextMeshProUGUI>();
        txt.text = petName;
        txt.enabled = true;
    }

    public void DisplayInfo()
    {
        TextMeshProUGUI lvl = pet3Level.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Xp = pet3Xp.GetComponent<TextMeshProUGUI>();
        lvl.text = "Level: " + level;
        Xp.text = "XP: " + xp;
    }

    string GetName()
    {
        return petName;
    }

    int GetLevel()
    {
        return level;
    }

    int GetXp()
    {
        return xp;
    }

    public bool GetUnlocked() {
        return unlocked;
    }

    void ChangeName(string name)
    {
        PlayerPrefs.SetString("pet3Name", name);
    }

    void IncreaseLevel()
    {
        PlayerPrefs.SetInt("pet3Level", level + 1);
    }

    void IncreaseXp(int addedXp)
    {
        xp += addedXp;
        if (xp >= 100)
        {
            xp -= 100;
            IncreaseLevel();
        }
    }

}
