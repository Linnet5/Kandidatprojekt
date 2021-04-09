using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private const int scoreGoal = 3;

    private int repProgress = 0;
    private int attempts = 0;

    [SerializeField] private int repGoal;
    [SerializeField] private GameObject gm;
    [SerializeField] private GameObject calibrationParentObj;

    public AudioClip success;
    public AudioClip fail;
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
        Debug.Log(repProgress);
    }

    private void OnTriggerEnter(Collider other)
    {
        attempts++;

        if (repProgress == repGoal)
        {
            //Successful rep
            gmScript.IncrementScore();
            if(gmScript.score == scoreGoal)
            {
                //Win the game
                audioSource.PlayOneShot(victory);
                audioSource.PlayOneShot(greatJob);
                Vibration.Vibrate(1000);
                calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(0); //Pauses player movement

                //Display results
                gameCanvas.SetActive(false);
                resultsCanvas.SetActive(true);
                bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText("Succesful reps: " + scoreGoal + "\n Failed reps: " + (attempts - scoreGoal));
            }
            else
            { 
                Vibration.Vibrate(100);
                audioSource.PlayOneShot(success);
            }
        }
        else
        {
            if(attempts - gmScript.score == 3)
            {
                calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(0); //Pauses player movement
                audioSource.PlayOneShot(tip);
                StartCoroutine(SoundPlayed());
               

            }

            else
            {
                audioSource.PlayOneShot(fail);
            }
        }
        repProgress = 0;
        calibrationParentObj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        
        

    }
    IEnumerator SoundPlayed()
    {
        yield return new WaitForSeconds(7);
        calibrationParentObj.GetComponent<Movement>().SetMovementSpeed(4); //unpauses player movement
    }
}
    
