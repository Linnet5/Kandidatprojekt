using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoordinates : MonoBehaviour
{
    GyroManager gm;
    void Start()
    {
        StartCoroutine("Calibrate");
    }

    IEnumerator Calibrate()
    {
        yield return new WaitForSeconds(2.0f);
        gm = GameObject.Find("Spawned GyroManager").GetComponent<GyroManager>();
        transform.Rotate(0.0f, gm.GetGyroRotation().eulerAngles.y, 0.0f, Space.World);
    }
}
