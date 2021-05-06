using Mirror;
using UnityEngine;

namespace InfallibleCode.Unity.Multiplayer.Mirror
{
    [RequireComponent(typeof(NetworkIdentity))]
    public class MirrorMultiplayerObject : MultiplayerObject
    {
        private NetworkIdentity _networkIdentity;

        private void Awake()
        {
            _networkIdentity = GetComponent<NetworkIdentity>();
        }

        public override bool IsLocalPlayer => _networkIdentity.isLocalPlayer;
    }
}
