using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    public bool canMove;
    int fCounter = 140;
    int restCounter = 200;

    // Start is called before the first frame update
    void Start()
    {
        canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            //transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);

            if (fCounter % restCounter == 0) {
                GameObject.Find("Sound Down").GetComponent<SoundTrigger>().audioSource.PlayOneShot(GameObject.Find("Sound Down").GetComponent<SoundTrigger>().clip);
            }

            if ((fCounter-65) % restCounter == 0)
            {
                GameObject.Find("Sound Up").GetComponent<SoundTrigger>().audioSource.PlayOneShot(GameObject.Find("Sound Up").GetComponent<SoundTrigger>().clip);
            }

            if ((fCounter-130) % restCounter == 0){
                Debug.Log("NU ANALYSERAR JAG ÖVNINGEN");
                GameObject.Find("Goal").GetComponent<Goal>().SquatGame();
            }

            fCounter++;
        }
    }

    public void SetMovementSpeed(int inSpeed)
    {
        movementSpeed = inSpeed;
    } 

}
