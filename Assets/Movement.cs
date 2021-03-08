using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private bool isSquatting;

    // Start is called before the first frame update
    void Start()
    {
        isSquatting = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown("space"))
        {
            toggleSquat();
        }
    }

    private void toggleSquat()
    {
        if (isSquatting)
        {
            StartCoroutine("Jump");
            isSquatting = false;
        }
        else
        {
            transform.position = transform.position - new Vector3(0, 0.5f, 0);
            isSquatting = true;
        }
    }

    IEnumerator Jump()
    {
        transform.position = transform.position + new Vector3(0, 0.5f, 0);
        yield return new WaitForSeconds(0.5f);
        transform.position = transform.position - new Vector3(0, 0.5f, 0);
    }
}
