using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelText : MonoBehaviour
{

    Vector3 accel;
    void Update()
    {
        accel = Input.acceleration;
        GetComponent<Text>().text = accel.ToString();
    }
}
