using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    private void Start() {
        GyroManager.Instance.EnableGyro();
    }

    private void Update() {
        Quaternion appliedRot = GyroManager.Instance.GetGyroRotation() * baseRotation;
        transform.localRotation = appliedRot;
    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
