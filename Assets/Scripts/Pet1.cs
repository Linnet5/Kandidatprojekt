using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEngine.EventSystems;
public class Pet1 : MonoBehaviour
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
    private bool pet1Upgraded;
    GameObject pet1;
    GameObject pet1Name;
    GameObject pet1Level;
    GameObject pet1Xp;
    public GameObject pet1Atk;
    public GameObject pet1Def;
    public GameObject pet1Hp;
    public GameObject pet1Mp;
    UnityEngine.UI.RawImage pet1Image;
    public Texture2D pet1UpgradeImage;
    GameObject petList;
    public GameObject pet1Inspect;
    // Start is called before the first frame update
    void Awake()
    {
        // Find game objects attached to pet
        pet1 = GameObject.Find("Pet 1");
        pet1Name = transform.Find("NamePet1").gameObject;
        pet1Level = transform.Find("LevelPet1").gameObject;
        pet1Xp = transform.Find("XpPet1").gameObject;
        pet1Image = pet1.GetComponent<RawImage>();

        Debug.Log(pet1UpgradeImage);
        petList = GameObject.Find("PetList");

        // Set private variables
        petName = PlayerPrefs.GetString("pet1Name");
        level = PlayerPrefs.GetInt("pet1Level");
        xp = PlayerPrefs.GetInt("pet1Xp");
        chosen = bool.Parse(PlayerPrefs.GetString("pet1Chosen"));
        unlocked = bool.Parse(PlayerPrefs.GetString("pet1Unlocked"));
        id = PlayerPrefs.GetInt("pet1Id");
        atk = PlayerPrefs.GetInt("pet1Atk");
        def = PlayerPrefs.GetInt("pet1Def");
        hp = PlayerPrefs.GetInt("pet1Hp");
        mp = PlayerPrefs.GetInt("pet1Mp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData) {
        if (eventData.pointerCurrentRaycast.gameObject.GetComponent<RawImage>()) {
            pet1Inspect.SetActive(true);
            petList.SetActive(false);
        }
    }

    public void DisplayName()
    {
        TextMeshProUGUI txt = pet1Name.GetComponent<TextMeshProUGUI>();
        txt.SetText(PlayerPrefs.GetString("pet1Name"));
        txt.enabled = true;
    }

    public void DisplayInfo()
    {
        if (pet1Inspect.activeSelf) {
            TextMeshProUGUI lvl = pet1Level.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Xp = pet1Xp.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Atk = pet1Atk.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Def = pet1Def.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Hp = pet1Hp.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI Mp = pet1Mp.GetComponent<TextMeshProUGUI>();
            lvl.text = "Level: " + PlayerPrefs.GetInt("pet1Level");
            Xp.text = "XP: " + PlayerPrefs.GetInt("pet1Xp");
            Atk.text = "Atk: " + PlayerPrefs.GetInt("pet1Atk");
            Def.text = "Def: " + PlayerPrefs.GetInt("pet1Def");
            Hp.text = "Hp: " + PlayerPrefs.GetInt("pet1Hp");
            Mp.text = "Mp: " + PlayerPrefs.GetInt("pet1Mp");
        }

        pet1Upgraded = bool.Parse(PlayerPrefs.GetString("pet1Upgraded"));
        pet1 = GameObject.Find("Pet 1");
        pet1Image = pet1.GetComponent<RawImage>();

        if (pet1Upgraded) {
            pet1Image.texture = pet1UpgradeImage;
        }
    }

    public string GetName()
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
        PlayerPrefs.SetString("pet1Name", name);
    }
}
