using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GravityRoomEnter : MonoBehaviour
{
    public event Action OnEnter;

    private void DisminuirGravedad()
    {
        OnEnter?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DisminuirGravedad();
        }
    }
}