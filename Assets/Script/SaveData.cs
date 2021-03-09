using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [SerializeField] private PotionData _PotionData = new PotionData();

    public void SaveIntoJson()
    {
        string potion = JsonUtility.ToJson(_PotionData);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PotionData.json", potion);
    }
}

/* https:// prasetion.medium.com/saving-data-as-json-in-unity-4419042d1334 */

[System.Serializable]
public class PotionData
{
    public string potion_name;
    public int value;
    public List<Effect> effect = new List<Effect>();
}

[System.Serializable]
public class Effect
{
    public string name;
    public string desc;
}
