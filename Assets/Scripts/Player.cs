using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] private Vector3 movement = new Vector3();
    public Canvas ControllerUI;

    private void Start()
    {
        if (!hasAuthority) { return; }
        Instantiate(ControllerUI);

    }

    //Moves Player Forward
    public void MoveForward()
    {
        if(!hasAuthority) {
            Debug.Log("No Authority");
            return; 
        }
        transform.Translate(movement);
    }
}
