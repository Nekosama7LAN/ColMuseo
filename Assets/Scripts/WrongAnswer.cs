using UnityEngine;
using System;

public class WrongAnswer : MonoBehaviour
{
    public event Action OnWrong;

    private void OnMouseDown()
    {
        OnWrong?.Invoke();
    }
}
