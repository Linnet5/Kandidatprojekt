using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelText : MonoBehaviour
{

    Vector3 accel;
    void Update()
    {
        accel = GameObject.Find("RECORDER").GetComponent<FollowAccel>().GetAccel();
        GetComponent<Text>().text = accel.ToString();

    }
}
