using UnityEngine;
using System;

public class ElevatorButton : MonoBehaviour
{
    public event Action OnElevator;
    [SerializeField] Elevator elevator;

    private void OnMouseDown()
    {
        elevator.counter = 0;
    }
}
