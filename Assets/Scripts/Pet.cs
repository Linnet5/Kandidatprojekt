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
        image.sprite = Resources.Load<Sprite>("Assets/Art/Characters/character_2.png");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Pet()
    {
        ReadData("pet_1");
        
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
                level = int.Parse(inp_ln);
            }
            else if (ln_counter == 1)
            {
                xp = int.Parse(inp_ln);
            }
            ln_counter++;
        }
    }

    private int level;
    private int xp;
    [SerializeField] private UnityEngine.UI.Image image;
}
