using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoordinates : MonoBehaviour
{
    GyroManager gm;
    private float initialYAngle = 0f;
    private GameObject target;
    private GameObject rotateIcon;

    //Audio variables
    public AudioSource audioSource;
    public AudioClip three;
    public AudioClip two;
    public AudioClip one;
    public AudioClip go;
    [SerializeField] private GameObject bodyText;

    [SerializeField] [TextArea] private string instructionText;
    void Start()
    {
        rotateIcon = GameObject.Find("counter-clockwise-icon");

        //if(rotateIcon.activeSelf)
        //    rotateIcon.SetActive(false);

        StartCoroutine("Calibrate");
        initialYAngle = transform.rotation.y;
        target = GameObject.Find("Target");
    }

    IEnumerator Calibrate()
    {
        yield return new WaitForSeconds(3.0f);
        //gm = GameObject.Find("Spawned GyroManager").GetComponent<GyroManager>();
        //transform.LookAt(new Vector3(target.transform.position.x, 0f, target.transform.position.z));
        //bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText(
        //    "Turn your phone counter-clockwise, put it against your chest and lay down. A countdown will indicate when the exercise is about to start.");
        //rotateIcon.SetActive(true);
        StartCoroutine("StartExercise");
    }

    IEnumerator StartExercise()
    {
        //yield return new WaitForSeconds(10.0f);
        audioSource.PlayOneShot(three);
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(two);
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(one);
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(go);

        bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText(
        "CURRENTLY IN A TRAINING SESSION. REMEMBER TO HAVE THE PHONE IN THE CORRECT POSITION AND FOLLOW THE INSTRUCTIONS.");
        //bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText("dE: ");

        //rotateIcon.SetActive(false);
        gameObject.GetComponent<Movement>().canMove = true;
    }
}
