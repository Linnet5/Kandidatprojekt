using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private int score = 0; 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 3)
        {
            Debug.Log("YOU DID IT WOW!!!!!");
        }
    }

    public void IncrementScore() {
        score++;
        
    }
}
