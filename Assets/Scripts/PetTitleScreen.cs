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
