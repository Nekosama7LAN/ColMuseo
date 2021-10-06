using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pregunta1Manager : MonoBehaviour
{
    public event Action OnCorrect;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void BotonCorrecto()
    {
        print("Correcto");
        OnCorrect?.Invoke();
    }

    public void BotonIncorrecto()
    {
        print("Incorrecto");
    }

    private void OnMouseDown()
    {
        BotonCorrecto();
    }
}
