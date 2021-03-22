using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    private Vector3 initial = new Vector3(90, 180, 0);
    private Transform appliedGyroRotation;
    private float appliedY = 0;
    private float initialY = 0;
    private float calibrateY = 0;

    private IEnumerator Start() {
        GyroManager.Instance.EnableGyro();
        initialY = transform.eulerAngles.y;
        appliedGyroRotation = new GameObject("Player").transform;

        yield return new WaitForSeconds(1);

        StartCoroutine(Tja());
    }

    private IEnumerator Tja()
    {
        calibrateY = appliedY - initialY;
        yield return null;
    }
 

    private void Update() {
        transform.eulerAngles = initial;
        appliedGyroRotation.rotation = Input.gyro.attitude;
        appliedY = appliedGyroRotation.eulerAngles.y;

        appliedGyroRotation.Rotate(0f, -calibrateY, 0);



        transform.localRotation = appliedGyroRotation.rotation;
    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
