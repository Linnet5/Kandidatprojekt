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

        GetComponent<Transform>().position += accel;
    }
}
