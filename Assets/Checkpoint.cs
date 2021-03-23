using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameObject goal;
    private Goal goalScript;
    // Start is called before the first frame update
    void Start()
    {
        goalScript = goal.GetComponent<Goal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        goalScript.IncrementProgress();
    }
}
