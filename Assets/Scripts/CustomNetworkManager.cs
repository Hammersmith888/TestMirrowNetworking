using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomNetworkManager : NetworkManager
{
    public override void OnClientConnect()
    {
        Debug.Log("connect Player");
    }

}
