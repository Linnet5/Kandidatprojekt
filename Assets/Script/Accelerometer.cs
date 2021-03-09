using UnityEngine;
using UnityEngine.UI;

public class Accelerometer : MonoBehaviour
{

    //Move object using accelerometer
    float speed = 1.0f;



    // Update is called once per frame
    void Update()
    {
        
        Vector3 dir = Vector3.zero;
        
        //we assume that device is held parallel to the ground
        //and Home button is in the right hand

        //remap device acceleration axis to game coordinates:
        // 1) XY plane of the device is mapped onto XZ plane
        // 2) rotate 90 degrees around Y axis 
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;
        Debug.Log("Accelerometer.bbbbbbbbbbbbbbb.." + dir.ToString());

        //clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        //Make it move 10 meters per second instead of 10 meters per frame....
        dir *= Time.deltaTime;

        //Move object
        transform.Translate(dir * speed);

        //Skriva ut
        //GetComponent<Text>().text = dir.ToString();
        
        
    }
  
    //Collition with object TEST
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit a trigger-Accel!");  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hitt collision-Accel");
    }

}
