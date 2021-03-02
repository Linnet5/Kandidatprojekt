using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkManagerCustom : NetworkManager {
    [SerializeField] GameObject connectionInstructions;

    // Start is called before the first frame update
    public override void Start()
    {
        connectionInstructions = GameObject.Find("ConnectionInstructions");
    }

    public override void OnServerConnect(NetworkConnection conn)
    {
        Destroy(connectionInstructions);
    }
}
