using UnityEngine;
using System.Collections.Generic;
using System;

public class WrongAnswer : MonoBehaviour
{
    public event Action OnWrong;

    [SerializeField] private List<GameObject> listOfAnswers = new List<GameObject>();

    public void BotonIncorrecto()
    {
        OnWrong?.Invoke();
        DestroyButtons();
    }

    private void OnMouseDown()
    {
        BotonIncorrecto();
    }

    private void DestroyButtons()
    {
        for (int i = 0; i < listOfAnswers.Count ; i++)
        {
            listOfAnswers[i].SetActive(false);
        }
        this.gameObject.SetActive(false);
    }
}
