using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccTranslation : MonoBehaviour
{
    float dt = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a;
        Vector3 a_avg = Vector3.zero;
        
        foreach (AccelerationEvent ae in Input.accelerationEvents)
        {
            a = ae.acceleration;
            a_avg += a;
            Debug.Log("dt: " + ae.deltaTime);
            dt += ae.deltaTime;
        }
        float m = a_avg.magnitude;
        
        a_avg *= (dt * dt);
        a_avg = RemoveNoise(a_avg);
        a_avg.y += 0.01f;
        Debug.Log(a_avg.x + ", " + a_avg.y + ", " + a_avg.z);
        Debug.Log(m);

        if (dt > 0.1)
        {
            transform.Translate(a_avg * m * m);
            dt = 0.0f;
        }
        
    }

    // Ignore small accelerometer inputs
    Vector3 RemoveNoise(Vector3 v)
    {
        Vector3 v_f;
        if (v.x > -0.0005 && v.x < 0.0005)
        {
            v_f.x = 0;
        }
        else
        {
            v_f.x = v.x;
        }
        if (v.y > -0.0005 && v.y < 0.0005)
        {
            v_f.y = 0;
        }
        else
        {
            v_f.y = v.y;
        }
        if (v.z > -0.0005 && v.z < 0.0005)
        {
            v_f.z = 0;
        }
        else
        {
            v_f.z = v.z;
        }
        return v_f;
    }
}

