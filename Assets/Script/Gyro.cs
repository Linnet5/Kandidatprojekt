using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{

    //Gyro
    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            Debug.Log("Im alive in Gyro Start!");
           
        }

    }

   
    
    // Update is called once per frame
    void Update()
    {
        //Gyro
       if (SystemInfo.supportsGyroscope)
           transform.rotation = GyroToUnity(Input.gyro.attitude);
       

    }
    
    //Gryo
    //Ska vara private
    private Quaternion GyroToUnity(Quaternion q)
    {
        Debug.Log("Gyro heeeeeeeeeeeeej.." + q.ToString());
         //Debug.Log("Gyro..." + Quaternion.q.ToString());
        return new Quaternion(q.x, q.y, -q.z, -q.w);
       

    }

    //ToString

    //collide
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit a trigger-Gyro!");
    }

}
