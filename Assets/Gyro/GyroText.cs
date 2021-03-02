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
        GetComponent<Text>().text = gyroRot.ToString();
    }
}
