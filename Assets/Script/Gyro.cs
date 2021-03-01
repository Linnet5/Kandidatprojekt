using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            Debug.Log("Im alive!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.supportsGyroscope)
            transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
