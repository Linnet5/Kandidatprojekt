using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    Vector3 accel;

    // Update is called once per frame
    void Update()
    {
        accel = GameObject.Find("Recorder").GetComponent<FollowAccel>().GetAccel();

        GetComponent<Transform>().rotation = Quaternion.Euler(90, 0, 180)*Input.gyro.attitude;
        //GetComponent<Transform>().position += accel;
    }
}
