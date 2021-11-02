using UnityEngine;
using System;

public class GravityRoomExit : MonoBehaviour
{
    public event Action OnExit;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GravityUp();
        }
    }

    private void GravityUp()
    {
        OnExit?.Invoke();
    }
}