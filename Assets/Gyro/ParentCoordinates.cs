using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoordinates : MonoBehaviour
{
    GyroManager gm;
    private float initialYAngle = 0f;
    void Start()
    {
        StartCoroutine("Calibrate");
        initialYAngle = transform.rotation.y;
    }

    IEnumerator Calibrate()
    {
        yield return new WaitForSeconds(2.0f);
        gm = GameObject.Find("Spawned GyroManager").GetComponent<GyroManager>();
        transform.Rotate(0f, initialYAngle -gm.GetGyroRotation().eulerAngles.y, 0f, Space.World);
    }
}
