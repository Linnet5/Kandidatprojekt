using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private const int attemptGoal = 10;

    private int repProgress = 0;
    private int attempts = 0;
    private int great = 0;
    private int ok = 0;
    private int miss = 0; 

    [SerializeField] private int repGoal;
    [SerializeField] private GameObject gm;
    [SerializeField] private GameObject calibrationParentObj;

    public AudioClip greatSound;
    public AudioClip okSound;
    public AudioClip missSound;
    public AudioClip greatJob;
    public AudioClip victory;
    public AudioClip tip;
    public AudioSource audioSource; 

    private GameMaster gmScript;

    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private GameObject resultsCanvas;
    [SerializeField] private GameObject bodyText;

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
        gmScript.IncrementScore(100);
        Debug.Log(repProgress);
    }

    private void OnTriggerEnter(Collider other)
    {
        attempts++;

        if (repProgress == repGoal)
        {
            //Successful rep

            gmScript.IncrementScore(500);
            great++;
            if (attempts != attemptGoal)
            {
                Vibration.Vibrate(100);
                audioSource.PlayOneShot(greatSound);
            }
        }
        else if (repProgress == repGoal - 1)
        {
            //ok rep
            gmScript.IncrementScore(200);
            ok++;
            if (attempts != attemptGoal)
            {
                Vibration.Vibrate(50);
                audioSource.PlayOneShot(okSound);
            }
        }
        else
        {
            //failed rep
            miss++;
            if (attempts != attemptGoal)
            {
                if (attempts - great == 5)
                {
                    calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(0); //Pauses player movement
                    audioSource.PlayOneShot(tip);
                    StartCoroutine(SoundPlayed(7));


                }

                else
                {
                    audioSource.PlayOneShot(missSound);
                }
            }
        }
        
        if (attempts == attemptGoal)
        {
            //Win the game
            audioSource.PlayOneShot(victory);
            if (great >= 5)
            {
                audioSource.PlayOneShot(greatJob);
            }
            Vibration.Vibrate(1000);
            calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(0); //Pauses player movement

            //Display results
            gameCanvas.SetActive(false);
            resultsCanvas.SetActive(true);
            bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText("Great: " + great + "\n ok: " + ok + "\n miss: " + miss + "\n SCORE: " + gmScript.score/attemptGoal);
        }

        repProgress = 0;
        calibrationParentObj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);     

    }
    IEnumerator SoundPlayed(int s)
    {
        yield return new WaitForSeconds(s);
        calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(4); //unpauses player movement
    }
}
    
