using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsLevelProgress : MonoBehaviour
{
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject unlockButton;

    // Start is called before the first frame update
    void OnEnable()
    {
        int currentExercise = PlayerPrefs.GetInt("currentExercise");
        Debug.Log(PlayerPrefs.GetInt("currentExercise"));
        switch (currentExercise)
        {
            case 0:
                nextButton.SetActive(true);
                unlockButton.SetActive(false);
                PlayerPrefs.SetInt("currentExercise", 1);
                break;
            case 1:
                nextButton.SetActive(true);
                unlockButton.SetActive(false);
                PlayerPrefs.SetInt("currentExercise", 2);
                break;
            case 2:
                nextButton.SetActive(true);
                unlockButton.SetActive(false);
                PlayerPrefs.SetInt("currentExercise", 3);
                break;
            case 3:
                if(!bool.Parse(PlayerPrefs.GetString("pet2Unlocked")))
                {
                    nextButton.SetActive(false);
                    unlockButton.SetActive(true);
                    PlayerPrefs.SetString("pet2FirstTimeUnlock", "true");
                }
                else if(!bool.Parse(PlayerPrefs.GetString("pet3Unlocked")))
                {
                    nextButton.SetActive(false);
                    unlockButton.SetActive(true);
                    PlayerPrefs.SetString("pet3FirstTimeUnlock", "true");
                }
                else
                {
                    nextButton.SetActive(true);
                    unlockButton.SetActive(false);
                }

                PlayerPrefs.SetInt("currentExercise", 0);
                break;

            default: 
                break;
        }
    }
}
