using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ConnectUI : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    public GameObject networkManager;

    // Start is called before the first frame update
    void Start()
    {
        networkManager = GameObject.Find("NetworkManager");

        if (SystemInfo.deviceType != DeviceType.Handheld)
        {
            Destroy(gameObject);
        }
    }

    //Refresh the list of joinable servers
    public void RefreshList()
    {
        networkManager.GetComponent<Mirror.Discovery.NetworkDiscoveryHUD_Custom>().RefreshList();
    }
        
}