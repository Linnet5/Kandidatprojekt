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
    private int atk;
    private int def;
    private int hp;
    private int mp;
    GameObject pet3;
    GameObject pet3Name;
    GameObject pet3Level;
    GameObject pet3Xp;
    public GameObject pet3Atk;
    public GameObject pet3Def;
    public GameObject pet3Hp;
    public GameObject pet3Mp;
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
        atk = PlayerPrefs.GetInt("pet3Atk");
        def = PlayerPrefs.GetInt("pet3Def");
        hp = PlayerPrefs.GetInt("pet3Hp");
        mp = PlayerPrefs.GetInt("pet3Mp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayName()
    {
        TextMeshProUGUI txt = pet3Name.GetComponent<TextMeshProUGUI>();
        txt.SetText(PlayerPrefs.GetString("pet3Name"));
        txt.enabled = true;
    }

    public void DisplayInfo()
    {
        TextMeshProUGUI lvl = pet3Level.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Xp = pet3Xp.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Atk = pet3Atk.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Def = pet3Def.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Hp = pet3Hp.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Mp = pet3Mp.GetComponent<TextMeshProUGUI>();
        lvl.text = "Level: " + level;
        Xp.text = "XP: " + xp;
        Atk.text = "Atk: " + PlayerPrefs.GetInt("pet3Atk");
        Def.text = "Def: " + PlayerPrefs.GetInt("pet3Def");
        Hp.text = "Hp: " + PlayerPrefs.GetInt("pet3Hp");
        Mp.text = "Mp: " + PlayerPrefs.GetInt("pet3Mp");
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
