using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Discovery
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Network/NetworkDiscoveryHUD Custom")]
    [HelpURL("https://mirror-networking.com/docs/Articles/Components/NetworkDiscovery.html")]
    [RequireComponent(typeof(NetworkDiscovery))]
    public class NetworkDiscoveryHUD_Custom : MonoBehaviour
    {
        readonly Dictionary<long, ServerResponse> discoveredServers = new Dictionary<long, ServerResponse>();
        Vector2 scrollViewPos = Vector2.zero;

        public NetworkDiscovery networkDiscovery;
        [SerializeField] private GameObject joinButton;
        [SerializeField] private GameObject connectionUI;
        [SerializeField] private GameObject instructionCanvas;
        private GameObject content;

#if UNITY_EDITOR
        void OnValidate()
        {
            if (networkDiscovery == null)
            {
                networkDiscovery = GetComponent<NetworkDiscovery>();
                UnityEditor.Events.UnityEventTools.AddPersistentListener(networkDiscovery.OnServerFound, OnDiscoveredServer);
                UnityEditor.Undo.RecordObjects(new Object[] { this, networkDiscovery }, "Set NetworkDiscovery");
            }
        }
#endif

        void Start()
        {
            //Fetch the content of the scroll view

            if (NetworkManager.singleton == null)
                return;

            if (NetworkServer.active || NetworkClient.active)
                return;

            if (!NetworkClient.isConnected && !NetworkServer.active && !NetworkClient.active)
            {
                if(SystemInfo.deviceType != DeviceType.Handheld)
                {
                    //Start server if device is not a mobile device
                    discoveredServers.Clear();
                    NetworkManager.singleton.StartServer();
                    networkDiscovery.AdvertiseServer();
                    Instantiate(instructionCanvas).name = "ConnectionInstructions";
                }
                else
                {
                    RefreshList();
                }
            }

            //Fetch content from gameobject in canvas
            content = connectionUI.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).gameObject;
        }

        void Draw()
        {
            //Clean up "no server" text
            if (discoveredServers.Count > 0)
                Destroy(GameObject.Find("NoServerFoundText"));

            //Instantiate a button for each active server (Bug: only finds one server)
            foreach (ServerResponse info in discoveredServers.Values)
            {
                var newJoinButton = Instantiate(joinButton, content.transform, false);
                newJoinButton.transform.position = new Vector3(newJoinButton.transform.position.x, newJoinButton.transform.position.y - (140 * discoveredServers.Count - 1), newJoinButton.transform.position.z);
                newJoinButton.GetComponent<Button>().onClick.AddListener( () => {
                    Connect(info);
                    Destroy(connectionUI);  //Connects to the chosen server and deletes the UI for server connecting.
                });
            }
        }

        //Refreshes list of servers
        public void RefreshList()
        {
            Draw();
            discoveredServers.Clear();
            networkDiscovery.StartDiscovery();
        }

        void Connect(ServerResponse info)
        {
            NetworkManager.singleton.StartClient(info.uri);
        }

        public void OnDiscoveredServer(ServerResponse info)
        {
            // Note that you can check the versioning to decide if you can connect to the server or not using this method
            discoveredServers[info.serverId] = info;
        }
    }
}
