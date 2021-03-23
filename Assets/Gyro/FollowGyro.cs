using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    Vector3 gyro;

    private void Start() {
        GyroManager.Instance.EnableGyro();
    }

    private void Update() {

        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;

        gyro.x = GyroManager.Instance.GetGyroRotation().x;
        gyro.y = GyroManager.Instance.GetGyroRotation().y;
        gyro.z = GyroManager.Instance.GetGyroRotation().z;
    }

    public Vector3 GetGyro()
    {
        return gyro;
    }
}


