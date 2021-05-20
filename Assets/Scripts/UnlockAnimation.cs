using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        if(bool.Parse(PlayerPrefs.GetString("pet2FirstTimeUnlock")))
        {
            animator.SetBool("pet3", false);
            animator.SetBool("pet2", true);
        }
        else if (bool.Parse(PlayerPrefs.GetString("pet3FirstTimeUnlock")))
        {
            animator.SetBool("pet2", false);
            animator.SetBool("pet3", true);
        }
    }
}
