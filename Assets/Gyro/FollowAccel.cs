using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowAccel : MonoBehaviour
{

    Vector3 accel;
    float magnitude;
    private void Start()
    {
        magnitude = 0.0f;
    }
    private void Update()
    {
        magnitude = GameObject.Find("accelSlider").GetComponent<Slider>().value;
        accel = Input.acceleration;
        GetComponent<Rigidbody>().AddForce(magnitude * accel);
        //GetComponent<Transform>().Translate(magnitude*accel);
    }

}
