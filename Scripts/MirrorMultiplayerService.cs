using Mirror;
using UnityEngine;

namespace InfallibleCode.Unity.Multiplayer.Mirror
{
    [RequireComponent(typeof(NetworkManager))]
    public class MirrorMultiplayerService : MultiplayerService
    {
        private NetworkManager _networkManager;

        private void Awake()
        {
            _networkManager = GetComponent<NetworkManager>();
        }

        public override void StartClient()
        {
            _networkManager.StartClient();
        }

        public override void StartHost()
        {
            _networkManager.StartHost();
        }
    }
}
