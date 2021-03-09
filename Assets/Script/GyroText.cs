using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroText : MonoBehaviour
{
    Quaternion gyroText;

    // Update is called once per frame
    void Update()
    {
        //gyroText = Input.gyro;
        GetComponent<Text>().text = gyroText.ToString();
        //Debug.Log("Hej" + gyroText);
    }
}
