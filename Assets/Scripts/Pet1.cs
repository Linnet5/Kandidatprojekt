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
    GameObject pet1;
    GameObject pet1Name;
    GameObject pet1Level;
    GameObject pet1Xp;
    UnityEngine.UI.RawImage pet1Image;
    GameObject petList;
    GameObject pet1Inspect;
    // Start is called before the first frame update
    void Awake()
    {
        // Find game objects attached to pet
        pet1 = GameObject.Find("Pet 1");
        pet1Name = transform.Find("NamePet1").gameObject;
        pet1Level = transform.Find("LevelPet1").gameObject;
        pet1Xp = transform.Find("XpPet1").gameObject;
        pet1Image = pet1.GetComponent<RawImage>();
        petList = GameObject.Find("PetList");

        // Set private variables
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
        TextMeshProUGUI lvl = pet1Level.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI Xp = pet1Xp.GetComponent<TextMeshProUGUI>();
        lvl.text = "Level: " + level;
        Xp.text = "XP: " + xp;
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
