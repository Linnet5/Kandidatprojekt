using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
public class Pet1 : MonoBehaviour
{
    private string petName;
    private int level;
    private int xp;
    private bool chosen;
    private bool unlocked;
    private int id;
    GameObject pet1;
    GameObject pet1Name;
    GameObject pet1Level;
    GameObject pet1Xp;
    // Start is called before the first frame update
    void Start()
    {
        pet1 = GameObject.Find("Pet 1");
        pet1Name = GameObject.Find("NamePet1");
        pet1Level = GameObject.Find("LevelPet1");
        pet1Xp = GameObject.Find("XpPet1");
        petName = PlayerPrefs.GetString("pet1Name");
        level = PlayerPrefs.GetInt("pet1Level");
        xp = PlayerPrefs.GetInt("pet1Xp");
        chosen = bool.Parse(PlayerPrefs.GetString("pet1Chosen"));
        unlocked = bool.Parse(PlayerPrefs.GetString("pet1Unlocked"));
        id = PlayerPrefs.GetInt("pet1Id");


    }

    // Update is called once per frame
    void Update()
    {

    }

    void Unlock()
    {
        PlayerPrefs.SetString("pet1Name", "Pet 1");
        PlayerPrefs.SetInt("pet1Level", 1);
        PlayerPrefs.SetInt("pet1Xp", 0);
        PlayerPrefs.SetString("pet1Chosen", "true");
        PlayerPrefs.SetString("pet1Unlocked", "true");
        PlayerPrefs.SetInt("pet1Id", 1);
    }

    public void DisplayName()
    {
        TextMeshProUGUI txt = pet1Name.GetComponent<TextMeshProUGUI>();
        txt.text = petName;
        txt.enabled = true;
    }

    public void DisplayInfo()
    {
        TextMeshProUGUI lvl = pet1Level.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Xp = pet1Xp.GetComponent<TextMeshProUGUI>();
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

    void ChangeName(string name)
    {
        PlayerPrefs.SetString("pet1Name", name);
    }

    void IncreaseLevel()
    {
        PlayerPrefs.SetInt("pet1Level", level + 1);
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
