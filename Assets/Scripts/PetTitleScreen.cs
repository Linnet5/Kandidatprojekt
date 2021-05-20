using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetTitleScreen : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update

    private void Awake()
    {
        //THIS IF STATEMENT ONLY HAPPENS ON FIRST TIME APP STARTUP
        if(bool.Parse(PlayerPrefs.GetString("firstTimeStartup", "true")))
        {
            PlayerPrefs.SetString("pet1Name", "Mole");
            PlayerPrefs.SetInt("pet1Level", 1);
            PlayerPrefs.SetInt("pet1Xp", 0);
            PlayerPrefs.SetInt("pet1Atk", 5);
            PlayerPrefs.SetInt("pet1Def", 3);
            PlayerPrefs.SetInt("pet1Hp", 10);
            PlayerPrefs.SetInt("pet1Mp", 10);
            PlayerPrefs.SetString("pet1Chosen", "true");
            PlayerPrefs.SetString("pet1Unlocked", "true");
            PlayerPrefs.SetInt("pet1Id", 1);
            PlayerPrefs.SetString("pet1Upgraded", "false");
            PlayerPrefs.SetString("pet1FirstTimeUnlock", "false");

            PlayerPrefs.SetString("firstTimeStartup", "false");
        }

        animator = gameObject.GetComponent<Animator>();

        if (bool.Parse(PlayerPrefs.GetString("pet1Chosen", "true")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet1Upgraded")))
            {
                animator.SetInteger("currentPet", 2); //Evolved form of pet1
            }
            else
            {
                animator.SetInteger("currentPet", 1);
            }
        }

        else if (bool.Parse(PlayerPrefs.GetString("pet2Chosen", "true")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet2Upgraded")))
            {
                animator.SetInteger("currentPet", 4); //Evolved form of pet2
            }
            else
            {
                animator.SetInteger("currentPet", 3);
            }
        }

        else if (bool.Parse(PlayerPrefs.GetString("pet3Chosen", "true")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet3Upgraded")))
            {
                animator.SetInteger("currentPet", 6); //Evolved form of pet3
            }
            else
            {
                animator.SetInteger("currentPet", 5);
            }
        }
    }
}
