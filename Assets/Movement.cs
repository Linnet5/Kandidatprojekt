using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
    }

    public void SetMovementSpeed(int inSpeed)
    {
        movementSpeed = inSpeed;
    } 

}
