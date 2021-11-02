using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class Score : MonoBehaviour
{
    public event Action OnCorrectSound;

    [SerializeField] private List<CorrectAnswer> listOfCorrectAnswers = new List<CorrectAnswer>();

    [SerializeField]private Text score;
    private int counter = 0;

    void Start()
    {
        for (int i = 0; i < listOfCorrectAnswers.Count; i++)
        {
            listOfCorrectAnswers[i].OnCorrect += AumentoPuntos;
        }
        score.text = counter.ToString();
    }

    private void AumentoPuntos()
    {
        counter++;
        score.text = counter.ToString();
        OnCorrectSound?.Invoke();
    }


}
