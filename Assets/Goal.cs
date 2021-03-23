using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private int repProgress = 0;
    private int repGoal = 0;
    [SerializeField] private GameObject gm;
    [SerializeField] private GameObject playerObj;
    private GameMaster gmScript;
    // Start is called before the first frame update
    void Start()
    {
        //repGoal changes depending on excerisize
        repGoal = 2;

        gmScript = gm.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementProgress()
    {
        repProgress++;
        Debug.Log(repProgress);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (repProgress == repGoal)
        {
            gmScript.IncrementScore();

        }
        repProgress = 0;
        playerObj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

    }

}
