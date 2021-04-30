using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aScreenOrientation : MonoBehaviour
{
    // Start is called before the first frame update
    public ScreenOrientation orientation;
    void Start()
    {
        Screen.orientation = orientation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
