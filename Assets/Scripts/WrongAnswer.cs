using UnityEngine;
using System;


public class WrongAnswer : MonoBehaviour
{
    public event Action OnWrong;


    public void BotonIncorrecto()
    {
        OnWrong?.Invoke();
        print("Incorrecto");
    }

    private void OnMouseDown()
    {
        BotonIncorrecto();
    }
}
