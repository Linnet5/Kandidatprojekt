using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroText : MonoBehaviour
{
    Quaternion gyroRot;
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    private void Start() {
        GyroManager.Instance.EnableGyro();
        
    }
    
    private void Update() {
        //gyroRot = GyroManager.Instance.GetGyroRotation();
        //GetComponent<Text>().text = gyroRot.ToString();
        Vector3 localDown = Quaternion.Inverse(Input.gyro.attitude) * Vector3.down;

        
        Quaternion referenceRotation = Quaternion.identity;
        Quaternion deviceRotation = new Quaternion(0.5f, 0.5f, -0.5f, 0.5f) * Input.gyro.attitude * new Quaternion(0, 0, 1, 0);
        Quaternion eliminationOfXY = Quaternion.Inverse(
            Quaternion.FromToRotation(referenceRotation * Vector3.forward,
                                      deviceRotation * Vector3.forward)
        );

        //Vector3 gyroData = GameObject.Find("Recorder").GetComponent<FollowGyro>().GetGyro();
        Vector3 gyroData = (Quaternion.Euler(90, 0, 180) * Input.gyro.attitude) * Vector3.up;
        //Vector3 gravity = new Vector3(0.0f, -1.0f, 0.0f);
        Vector3 gravity = Input.gyro.gravity;
        gravity = Quaternion.Euler(-90, 180, 180) * gravity*4.0f;
        Vector3 offset = new Vector3(0.0f,8.0f,0.0f);

        Debug.DrawLine(offset,gravity+offset,Color.red);
        float angle = (Vector3.Dot(gyroData, gravity)) / (gravity.magnitude * gyroData.magnitude);
        angle = angle * Mathf.Rad2Deg;
        GetComponent<Text>().text = angle.ToString();

    }
}
