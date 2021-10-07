using UnityEngine;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public event Action OnCorrect;

    public void BotonCorrecto()
    {
        print("Correcto");
        OnCorrect?.Invoke();
    }


    private void OnMouseDown()
    {
        BotonCorrecto();
    }
}
