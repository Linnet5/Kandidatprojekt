using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private int repProgress = 0;
    [SerializeField] private int repGoal;
    [SerializeField] private GameObject gm;
    [SerializeField] private GameObject calibrationParentObj;
    public AudioClip success;
    public AudioClip fail;
    public AudioClip greatJob;
    public AudioClip victory;
    public AudioSource audioSource; 

    private GameMaster gmScript;
    // Start is called before the first frame update
    void Start()
    {
        //repGoal changes depending on excerisize
        

        gmScript = gm.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementProgress()
    {
        repProgress++;
        Debug.Log(repProgress);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (repProgress == repGoal)
        {
            //Successful rep
            gmScript.IncrementScore();
            if(gmScript.score == 3)
            {
                //Win the game
                audioSource.PlayOneShot(victory);
                audioSource.PlayOneShot(greatJob);
                Vibration.Vibrate(1000);
                calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(0); //Pauses player movement
            }
            else
            { 
                Vibration.Vibrate(100);
                audioSource.PlayOneShot(success);
            }
        }
        else
        {
            audioSource.PlayOneShot(fail);
        }
        repProgress = 0;
        calibrationParentObj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        
        

    }

}
