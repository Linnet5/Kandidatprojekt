using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aScreenOrientation : MonoBehaviour
{
    // Start is called before the first frame update
    public ScreenOrientation orientation;
    public ScreenOrientation defaultOrientation; 

    void Start()
    {
        Screen.orientation = orientation;
    }
    
    public void DefaultOrientation()
    {
        Screen.orientation = defaultOrientation;
    }
}
