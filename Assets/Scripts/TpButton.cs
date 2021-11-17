using UnityEngine;
using System;

public class TpButton : MonoBehaviour
{
    public event Action OnTeleport;
    [SerializeField] private Shooter shooter;

    private void OnMouseDown()
    {
        OnTeleport?.Invoke();
        shooter.counter = 0;

    }  
}
