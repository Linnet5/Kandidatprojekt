using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{
    private string petName;
    private int level;
    private int xp;
    private bool chosen;
    private bool unlocked;
    private int id;
    GameObject pet1; 
    // Start is called before the first frame update
    void Start()
    {
        pet1 = GameObject.Find("Pet 1");
        ReadData("pet_1.txt");
        Debug.Log(pet1);
        if (unlocked)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReadData(string pet)
    {
        string file_path = "Assets/Petdata/" + pet;
        StreamReader inp_stm = new StreamReader(file_path);
        int ln_counter = 0;

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            if (ln_counter == 0)
            {
                petName = inp_ln;
            }
            else if (ln_counter == 1)
            {
                level = int.Parse(inp_ln);
            }
            else if (ln_counter == 2)
            {
                xp = int.Parse(inp_ln);
            }
            else if (ln_counter == 3)
            {
                chosen = bool.Parse(inp_ln);
            }
            else if (ln_counter == 4)
            {
                unlocked = bool.Parse(inp_ln);
            }
            else if (ln_counter == 5)
            {
                id = int.Parse(inp_ln);
            }
            ln_counter++;
        }
    }
}
