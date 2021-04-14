using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Pet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // image.sprite = Resources.Load<Sprite>("Assets/Art/Characters/character_2.png");
        ReadData("pet_1.txt");
        Debug.Log(petName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Pet()
    {
        
    }

    public void AddXp(int amount)
    {
        xp += amount;
        if (xp >= 100)
        {
            level += 1;
            xp -= 100;
        }
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
            ln_counter++;
        }
    }

    private string petName;
    private int level;
    private int xp;
    private bool chosen;

    [SerializeField] private UnityEngine.UI.Image image;
}
