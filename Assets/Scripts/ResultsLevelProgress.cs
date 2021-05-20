using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsLevelProgress : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        int currentExercise = PlayerPrefs.GetInt("currentExercise");
        switch (currentExercise)
        {
            case 1:
                PlayerPrefs.SetInt("currentExercise", 2);
                break;
            case 2:
                PlayerPrefs.SetInt("currentExercise", 3);
                break;
            case 3:
                PlayerPrefs.SetInt("currentExercise", 4);
                break;
            case 4:
                if(!bool.Parse(PlayerPrefs.GetString("pet2FirstTimeUnlock")))
                {
                    PlayerPrefs.SetString("pet2FirstTimeUnlock", "true");
                }
                else if(!bool.Parse(PlayerPrefs.GetString("pet3FirstTimeUnlock")))
                {
                    PlayerPrefs.SetString("pet3FirstTimeUnlock", "true");
                }

                PlayerPrefs.SetInt("currentExercise", 1);
                break;

            default: 
                break;
        }
    }
}
