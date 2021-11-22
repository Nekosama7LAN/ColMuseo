using UnityEngine;
using System;

public class TpButton : MonoBehaviour
{
    public event Action OnTeleport;

    private void OnMouseDown()
    {
        OnTeleport?.Invoke();
    }  
}
