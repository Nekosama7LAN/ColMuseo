using UnityEngine;
using System;

public class GravityRoomEnter : MonoBehaviour
{
    public event Action OnEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GravityDown();
        }
    }

    private void GravityDown()
    {
        OnEnter?.Invoke();
    }
}