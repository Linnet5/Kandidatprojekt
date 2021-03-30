using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoordinates : MonoBehaviour
{
    GyroManager gm;
    private float initialYAngle = 0f;
    private GameObject target;
    [SerializeField] private GameObject bodyText;
    void Start()
    {
        StartCoroutine("Calibrate");
        initialYAngle = transform.rotation.y;
        target = GameObject.Find("Target");
    }

    IEnumerator Calibrate()
    {
        yield return new WaitForSeconds(3.0f);
        gm = GameObject.Find("Spawned GyroManager").GetComponent<GyroManager>();
        transform.LookAt(new Vector3(target.transform.position.x, 0f, target.transform.position.z));
        gameObject.GetComponent<Movement>().canMove = true;
        bodyText.GetComponent<TMPro.TextMeshProUGUI>().SetText(
            "CURRENTLY IN A TRAINING SESSION. REMEMBER TO HAVE THE PHONE IN THE CORRECT POSITION AND FOLLOW THE INSTRUCTIONS.");
    }
}
