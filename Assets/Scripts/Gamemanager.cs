using System;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public event Action OnTpPlayer;

    public event Action OnPause;
    public event Action OnContinue;


    [SerializeField] GravityRoomEnter gravityRoomEnter;
    [SerializeField] GravityRoomExit gravityRoomExit = null;
    [SerializeField] GravityRoomExit gravityRoomExitTwo = null;


    [SerializeField] TpButton tpButton = null;

    [SerializeField] PlayerController player = null;

    private bool isPlay = true;
    [SerializeField] private Canvas pauseScreen;

    void Start()
    {
        tpButton.OnTeleport += TpPlayer;
        gravityRoomExit.OnExit += GravityRestart;
        gravityRoomEnter.OnEnter += RoomOfGravityUp;
        gravityRoomExitTwo.OnExit += GravityRestart;

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
            pauseScreen.gameObject.SetActive(true);
            OnPause?.Invoke();
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            pauseScreen.gameObject.SetActive(false);
            OnContinue?.Invoke();
        }
    }

    private void TpPlayer()
    {
        OnTpPlayer?.Invoke();
    }

    void RoomOfGravityUp()
    {
        player.gravityScale = -2f;
        player.avalibleJumps = 20;
    }

    void GravityRestart()
    {
        player.gravityScale = -20;
        player.avalibleJumps = 2;
    }
}
