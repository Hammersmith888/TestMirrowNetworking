using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Singletone
    private static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }
    #endregion
    public Vector3 movementVector = new Vector3();
    [SerializeField]
    private Player _playerObj;
    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        if(_playerObj)
            MoveInput();

    }
    public void SetPlayer(Player player)
    {
        _playerObj = player;
    }
    private void MoveInput()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.z = Input.GetAxis("Vertical");
        _playerObj.CmdMovePlayer(movementVector);
        _playerObj.MovePlayer(movementVector);
    }

    
}
