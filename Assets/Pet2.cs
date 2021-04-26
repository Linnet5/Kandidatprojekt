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
    private int atk;
    private int def;
    private int hp;
    private int mp;
    private bool imageChanged = false;
    GameObject pet2;
    GameObject pet2Name;
    GameObject pet2Level;
    GameObject pet2Xp;
    public GameObject pet2Atk;
    public GameObject pet2Def;
    public GameObject pet2Hp;
    public GameObject pet2Mp;
    UnityEngine.UI.RawImage pet2Image;
    public Texture2D pet2UpgradeImage;
    GameObject petList;
    public GameObject pet2Inspect;
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
        atk = PlayerPrefs.GetInt("pet2Atk");
        def = PlayerPrefs.GetInt("pet2Def");
        hp = PlayerPrefs.GetInt("pet2Hp");
        mp = PlayerPrefs.GetInt("pet2Mp");
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
        if (pet2Inspect.activeSelf) {
            TextMeshProUGUI lvl = pet2Level.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Xp = pet2Xp.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Atk = pet2Atk.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Def = pet2Def.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Hp = pet2Hp.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Mp = pet2Mp.GetComponent<TextMeshProUGUI>();
            lvl.text = "Level: " + PlayerPrefs.GetInt("pet2Level");
            Xp.text = "XP: " + PlayerPrefs.GetInt("pet2Xp");
            Atk.text = "Atk: " + PlayerPrefs.GetInt("pet2Atk");
            Def.text = "Def: " + PlayerPrefs.GetInt("pet2Def");
            Hp.text = "Hp: " + PlayerPrefs.GetInt("pet2Hp");
            Mp.text = "Mp: " + PlayerPrefs.GetInt("pet2Mp");
        }

        if (level >= 10 && !imageChanged) {
            pet2Image.texture = pet2UpgradeImage;
            imageChanged = true;
        }
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
        level = PlayerPrefs.GetInt("pet2Level");
        atk = PlayerPrefs.GetInt("pet2Atk");
        def = PlayerPrefs.GetInt("pet2Def");
        hp = PlayerPrefs.GetInt("pet2Hp");
        mp = PlayerPrefs.GetInt("pet2Mp");
        level += 1;
        if (level < 10) {
            atk += 2;
            def += 2;
            hp  += 3;
            mp  += 1;
        }
        else {
            atk += 2;
            def += 2;
            hp  += 4;
            mp  += 1;
        }
        PlayerPrefs.SetInt("pet2Level", level);
        PlayerPrefs.SetInt("pet2Atk", atk);
        PlayerPrefs.SetInt("pet2Def", def);
        PlayerPrefs.SetInt("pet2Hp", hp);
        PlayerPrefs.SetInt("pet2Mp", mp);
        DisplayInfo();
    }

    public void IncreaseXp(int addedXp)
    {
        xp = PlayerPrefs.GetInt("pet2Xp");
        level = PlayerPrefs.GetInt("pet2Level");
        xp += addedXp;
        if (xp >= (300 + level * 30) && level < 10)
        {
            xp -= (300 + level * 30);
            IncreaseLevel();
        }
        else if (xp >= (500 + level * 30)) {
            xp -= (500 + level * 30);
            IncreaseLevel();
        }
        PlayerPrefs.SetInt("pet2Xp", xp);
    }

}
