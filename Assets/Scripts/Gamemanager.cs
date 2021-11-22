using System;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public event Action OnTpPlayer;

    [SerializeField] GravityRoomEnter gravityRoomEnter = null;
    [SerializeField] GravityRoomExit gravityRoomExit = null;

    [SerializeField] TpButton tpButton = null;

    [SerializeField] PlayerController player = null;

    void Start()
    {
        tpButton.OnTeleport += TpPlayer;
        //gravityRoomExit.OnExit += GravityRestart;
        //gravityRoomEnter.OnEnter += RoomOfGravityUp;
    }

    private void TpPlayer()
    {
        OnTpPlayer?.Invoke();
    }

    //void RoomOfGravityUp()
    //{
    //    player.gravityScale = -2f;
    //}

    //void GravityRestart()
    //{
    //    player.gravityScale = -20;
    //}
}
