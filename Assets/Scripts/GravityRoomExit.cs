using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GravityRoomExit : MonoBehaviour
{
    public event Action OnExit;

    private void AumentarGravedad()
    {
        OnExit?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AumentarGravedad();
        }
    }
}