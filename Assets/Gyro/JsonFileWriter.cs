using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JsonFileWriter : MonoBehaviour
{
    public JsonData data;

    public string path;

    public void Start()
    {
        data = new JsonData(1, "Alfred Jodl");

        path = Path.Combine(Application.persistentDataPath, "saved files", "data.json");
        SerializeData();
        DeserializeData();
    }

    public void SerializeData()
    {
        string jsonDataString = JsonUtility.ToJson(data, true);

        File.WriteAllText(path, jsonDataString);

        Debug.Log(jsonDataString);
    }

    public void DeserializeData()
    {
        string loadedJsonDataString = File.ReadAllText(path);

        data = JsonUtility.FromJson<JsonData>(loadedJsonDataString);

        Debug.Log("id: " + data.id.ToString() + " | name: " + data.name)
     }
}

[Serializeable]
public class JsonData
{
    public int id;
    public string name;

    public JsonData(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public JsonData() { }
}