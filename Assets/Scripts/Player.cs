using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class Player : NetworkBehaviour
{
    [SyncVar]
    [SerializeField]
    private float speed;
    private Rigidbody _rb;

    private void Start()
    {

        _rb = this.GetComponent<Rigidbody>();
        if(isClient&&isLocalPlayer)
        {
            SetInputMangerPlayer();
            
        }
        if(isServer)
        {
            speed = 3;
        }
    }

    private void SetInputMangerPlayer()
    {
        InputManager.Instance.SetPlayer(this);
        
    }
    
    [Command]
    public void CmdMovePlayer(Vector3 movementVector)
    {

        _rb.AddForce(movementVector.normalized * speed);
    }
    public void MovePlayer(Vector3 movementVector)
    {

        _rb.AddForce(movementVector.normalized * speed);
    }





}
