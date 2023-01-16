using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private NetworkManager newManager;

    public void SpawnPlayer(bool clientLoadedScene)
    {
       if (!clientLoadedScene)
       {

            if (!NetworkClient.ready)
                NetworkClient.Ready();

            if (newManager.autoCreatePlayer)
                NetworkClient.AddPlayer();
        }
    }
}
