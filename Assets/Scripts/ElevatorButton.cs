using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    [SerializeField] Elevator elevator;
    [SerializeField] PlayerController player;
    private void OnMouseDown()
    {
        elevator.counter = 0;
        player.counter = 0;
    }
}
