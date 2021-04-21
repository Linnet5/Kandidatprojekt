using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
public class Pet2 : MonoBehaviour
{
    private string petName;
    private int level;
    private int xp;
    private bool chosen;
    private bool unlocked;
    private int id;
    GameObject pet2;
    GameObject pet2Name;
    GameObject pet2Level;
    GameObject pet2Xp;
    UnityEngine.UI.RawImage pet2Image;
    GameObject petList;
    GameObject pet2Inspect;
    // Start is called before the first frame update
    void Awake()
    {
        // Find game objects attached to pet
        pet2 = GameObject.Find("Pet 2");
        pet2Name = transform.Find("NamePet2").gameObject;
        pet2Level = transform.Find("LevelPet2").gameObject;
        pet2Xp = transform.Find("XpPet2").gameObject;
        pet2Image = pet2.GetComponent<RawImage>();
        petList = GameObject.Find("PetList");

        // Set private variables
        petName = PlayerPrefs.GetString("pet2Name");
        level = PlayerPrefs.GetInt("pet2Level");
        xp = PlayerPrefs.GetInt("pet2Xp");
        chosen = bool.Parse(PlayerPrefs.GetString("pet2Chosen"));
        unlocked = bool.Parse(PlayerPrefs.GetString("pet2Unlocked"));
        id = PlayerPrefs.GetInt("pet2Id");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayName()
    {
        TextMeshProUGUI txt = pet2Name.GetComponent<TextMeshProUGUI>();
        txt.SetText(PlayerPrefs.GetString("pet2Name"));
        txt.enabled = true;
    }

    public void DisplayInfo()
    {
        TextMeshProUGUI lvl = pet2Level.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Xp = pet2Xp.GetComponent<TextMeshProUGUI>();
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
        PlayerPrefs.SetString("pet2Name", name);
    }

    void IncreaseLevel()
    {
        PlayerPrefs.SetInt("pet2Level", level + 1);
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
