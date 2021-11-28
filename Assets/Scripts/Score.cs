using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class Score : MonoBehaviour
{
    public event Action OnCorrectSound;
    public event Action OnWrongSound;

    [SerializeField] private List<CorrectAnswer> listOfCorrectAnswers = new List<CorrectAnswer>();
    [SerializeField] private List<WrongAnswer> listOfWrongAnswers = new List<WrongAnswer>();

    [SerializeField]private Text score;
    private int counter = 0;

    void Start()
    {
        for (int i = 0; i < listOfCorrectAnswers.Count; i++)
        {
            listOfCorrectAnswers[i].OnCorrect += ScoreUp;
        }

        for (int i = 0; i < listOfWrongAnswers.Count; i++)
        {
            listOfWrongAnswers[i].OnWrong += WrongOption;
        }

        score.text = counter.ToString();
    }

    private void WrongOption()
    {
        OnWrongSound?.Invoke();
    }

    private void ScoreUp()
    {
        counter++;
        score.text = counter.ToString();
        OnCorrectSound?.Invoke();
    }



}
