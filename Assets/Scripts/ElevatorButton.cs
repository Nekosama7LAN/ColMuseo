using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    [SerializeField] Elevator elevator;
    private void OnMouseDown()
    {
        elevator.counter = 0;
    }
}
