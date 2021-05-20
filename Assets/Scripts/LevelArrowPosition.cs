using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelArrowPosition : MonoBehaviour
{
    private int currentExercise;
    [SerializeField] private GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        currentExercise = PlayerPrefs.GetInt("currentExercise");
        switch(currentExercise){
            case 0:
                arrow.transform.localPosition = new Vector3(17.4f, -77.5f, 0f);
                break;
            case 1:
                arrow.transform.localPosition = new Vector3(9.8f, -7.22f, 0f);
                break;
            case 2:
                arrow.transform.localPosition = new Vector3(8.2f, 59.9f, 0f);
                break;
            case 3:
                arrow.transform.localPosition = new Vector3(38f, 128.6f, 0f);
                break;
            
            default:
                arrow.transform.localPosition = new Vector3(17.4f, -77.5f, 0f);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
