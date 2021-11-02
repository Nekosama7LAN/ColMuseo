using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] GravityRoomEnter gravityRoomEnter = null;
    [SerializeField] GravityRoomExit gravityRoomExit = null;

    [SerializeField] PlayerController player = null;

    void Start()
    {
        gravityRoomExit.OnExit += GravityRestart;
        gravityRoomEnter.OnEnter += RoomOfGravityUp;
    }

    void RoomOfGravityUp()
    {
        player.gravityScale = -2f;
    }

    void GravityRestart()
    {
        player.gravityScale = -20;
    }
}
