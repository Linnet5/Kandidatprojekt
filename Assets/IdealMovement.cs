using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdealMovement : MonoBehaviour
{
    float s = 1.5f; // Speed
    bool movingUp = false;
    bool movingDown = true;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ds = s * Time.deltaTime;
        if (transform.position.y < 7.0f && transform.position.y > 3.0f && movingDown)
        {
            Vector3 v = new Vector3(0, -ds, 0);
            transform.Translate(v);
            movingUp = false;
        }

        if (transform.position.y < 3.0f) 
        {
            movingUp = true;
            movingDown = false;
        }

        if (movingUp)
        {
            Vector3 v = new Vector3(0, ds, 0);
            transform.Translate(v);
        }

        if (transform.position.y > 7.0f)
        {
            movingUp = false;
            movingDown = true;
        }

        if (movingDown)
        {
            Vector3 v = new Vector3(0, -ds, 0);
            transform.Translate(v);
        }

    }
}
