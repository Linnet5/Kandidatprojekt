using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccTranslation : MonoBehaviour
{
    float dt = 0.0f;
    public Rigidbody rb;
    bool onlyDown = false;
    bool onlyUp = false;
    bool stage1 = false;
    bool stage2 = false;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a;
        Vector3 a_avg = Vector3.zero;
        Vector3 p = GameObject.Find("AccTest").transform.position;

        foreach (AccelerationEvent ae in Input.accelerationEvents)
        {
            a = ae.acceleration;
            a_avg += a;
            dt += ae.deltaTime;
        }
        float m = a_avg.magnitude;
        a_avg.y += 1.0f;
        a_avg *= (dt * dt);
        // Debug.Log(a_avg.x + ", " + a_avg.y + ", " + a_avg.z);
        a_avg = RemoveNoise(a_avg);

        if (dt > 0.2 )
        {
            if (onlyDown)
            {
                if(a_avg.y < 0.0f)
                {
                    Vector3 v = new Vector3(0, 10.0f * a_avg.y * m * m, 0);
                    transform.Translate(v);
                    dt = 0.0f;
                }
                else
                {
                    Vector3 v = new Vector3(0, 0, 0);
                    transform.Translate(v);
                    dt = 0.0f;
                }
            }
            else if (onlyUp)
            {
                if (a_avg.y > 0.0f)
                {
                    Vector3 v = new Vector3(0, 10.0f * a_avg.y * m * m, 0);
                    transform.Translate(v);
                    dt = 0.0f;
                }
                else
                {
                    Vector3 v = new Vector3(0, 0, 0);
                    transform.Translate(v);
                    dt = 0.0f;
                }
            }
            else
            {
                Vector3 v = new Vector3(0, 10.0f * a_avg.y * m * m, 0);
                transform.Translate(v);
                dt = 0.0f;
            }
        }

        if (stage1 && stage2)
        {
            i++;
            stage1 = false;
            stage2 = false;
            Debug.Log(i);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        rb.constraints = RigidbodyConstraints.FreezePosition;
        if (other.name == "CollisionBot")
        {
            Debug.Log("Bottom");
            onlyUp = true;
            onlyDown = false;
            stage1 = true;

        }
        else if (other.name == "CollisionTop")
        {
            Debug.Log("Top");
            onlyDown = true;
            onlyUp = false;
            if (stage1)
            {
                stage2 = true;
            }
        }
    }



    // Ignore small accelerometer inputs
    // 0.003
    Vector3 RemoveNoise(Vector3 v)
    {
        Vector3 v_f;
        if (v.x > -0.003 && v.x < 0.003)
        {
            v_f.x = 0;
        }
        else
        {
            v_f.x = v.x;
        }
        if (v.y > -0.003 && v.y < 0.003)
        {
            v_f.y = 0;
        }
        else
        {
            v_f.y = v.y;
        }
        if (v.z > -0.003 && v.z < 0.003)
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

