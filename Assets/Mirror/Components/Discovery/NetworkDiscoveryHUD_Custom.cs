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
        private GameObject content;

        private void Start()
        {
            //Fetch the content of the scroll view
            content = connectionUI.transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).gameObject;
        }

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

        void OnGUI()
        {
            if (NetworkManager.singleton == null)
                return;

            if (NetworkServer.active || NetworkClient.active)
                return;

            if (!NetworkClient.isConnected && !NetworkServer.active && !NetworkClient.active)
            {
                DrawGUI();
                if (SystemInfo.deviceType != DeviceType.Handheld)
                {
                    discoveredServers.Clear();
                    NetworkManager.singleton.StartServer();
                    networkDiscovery.AdvertiseServer();
                }
            }
        }

        void DrawGUI()
        {

            GUILayout.BeginHorizontal();
            
            if (GUILayout.Button("Refresh Server List"))
            {
                discoveredServers.Clear();
                networkDiscovery.StartDiscovery();
            }

            foreach (ServerResponse info in discoveredServers.Values)
            {
                var newJoinButton = Instantiate(joinButton, content.transform, false);
                newJoinButton.transform.position = new Vector3(newJoinButton.transform.position.x, newJoinButton.transform.position.y - (140 * discoveredServers.Count), newJoinButton.transform.position.z);

                //newJoinButton.GetComponent<TextMesh>().text = "Computer " + discoveredServers.Count;    
                if (GUILayout.Button("Computer " + discoveredServers.Count))
                {
                    Connect(info);
                    Destroy(connectionUI);
                }
            }

            GUILayout.EndHorizontal();

            // show list of found server

            GUILayout.Label($"Discovered Servers [{discoveredServers.Count}]:");

            // servers
            scrollViewPos = GUILayout.BeginScrollView(scrollViewPos);   
            
            GUILayout.EndScrollView();
        }

        public void RefreshList()
        {
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
