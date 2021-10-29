using UnityEngine;
using System.Collections.Generic;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public event Action OnCorrect;
    public event Action OnSound;

    [SerializeField] private List<GameObject> listOfWrongAnswers = new List<GameObject>();

    private void BotonCorrecto()
    {
        OnCorrect?.Invoke();
        OnSound?.Invoke();
        DeleteButtons();
    }

    private void OnMouseDown()
    {
        BotonCorrecto();
    }

    private void DeleteButtons()
    {
        for (int i = 0; i < listOfWrongAnswers.Count ; i++)
        {
            listOfWrongAnswers[i].SetActive(false);
        }
        this.gameObject.SetActive(false);
    }
}
