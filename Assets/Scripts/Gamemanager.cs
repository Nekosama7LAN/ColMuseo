using System;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public event Action OnTpPlayer;

    [SerializeField] GravityRoomEnter gravityRoomEnter = null;
    [SerializeField] GravityRoomExit gravityRoomExit = null;

    [SerializeField] TpButton tpButton = null;

    [SerializeField] PlayerController player = null;

    private bool isPlay = true;
    [SerializeField] private Canvas pauseScreen;

    void Start()
    {
        tpButton.OnTeleport += TpPlayer;
        //gravityRoomExit.OnExit += GravityRestart;
        //gravityRoomEnter.OnEnter += RoomOfGravityUp;
    }

    private void Update()
    {
        PauseTheGame();
    }

    private void PauseTheGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        isPlay = !isPlay;
        if (isPlay == false)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
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
