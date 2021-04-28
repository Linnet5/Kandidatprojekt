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
    private bool pet3Upgraded;
    GameObject pet3;
    GameObject pet3Name;
    GameObject pet3Level;
    GameObject pet3Xp;
    public GameObject pet3Atk;
    public GameObject pet3Def;
    public GameObject pet3Hp;
    public GameObject pet3Mp;
    UnityEngine.UI.RawImage pet3Image;
    public Texture2D pet3UpgradeImage;
    GameObject petList;
    public GameObject pet3Inspect;
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
        if (pet3Inspect.activeSelf) {
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

        pet3Upgraded = bool.Parse(PlayerPrefs.GetString("pet3Upgraded"));
        pet3 = GameObject.Find("Pet 3");
        pet3Image = pet3.GetComponent<RawImage>();

        if (pet3Upgraded) {
            pet3Image.texture = pet3UpgradeImage;
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
        PlayerPrefs.SetString("pet3Name", name);
    }

    void IncreaseLevel()
    {
        level = PlayerPrefs.GetInt("pet3Level");
        atk = PlayerPrefs.GetInt("pet3Atk");
        def = PlayerPrefs.GetInt("pet3Def");
        hp = PlayerPrefs.GetInt("pet3Hp");
        mp = PlayerPrefs.GetInt("pet3Mp");
        level += 1;
        if (level >= 12) {
            PlayerPrefs.SetString("pet3Upgraded", "true");
        }
        if (level < 12) {
            atk += 2;
            def += 1;
            hp  += 1;
            mp  += 1;
        }
        else {
            atk += 3;
            def += 1;
            hp  += 2;
            mp  += 1;
        }
        PlayerPrefs.SetInt("pet3Level", level);
        PlayerPrefs.SetInt("pet3Atk", atk);
        PlayerPrefs.SetInt("pet3Def", def);
        PlayerPrefs.SetInt("pet3Hp", hp);
        PlayerPrefs.SetInt("pet3Mp", mp);
        DisplayInfo();
    }

    public void IncreaseXp(int addedXp)
    {
        xp = PlayerPrefs.GetInt("pet3Xp");
        level = PlayerPrefs.GetInt("pet3Level");
        xp += addedXp;
        if (xp >= (400 + level * 40) && level < 12)
        {
            xp -= (400 + level * 40);
            IncreaseLevel();
        }
        else if (xp >= (600 + level * 40)) {
            xp -= (600 + level * 40);
            IncreaseLevel();
        }
        PlayerPrefs.SetInt("pet3Xp", xp);
    }

}
