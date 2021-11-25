using System.Collections.Generic;
using UnityEngine;

public class PaintController : MonoBehaviour
{
    [SerializeField] private List<GameObject> listOfAnswers = new List<GameObject>();
    [SerializeField] private List<WrongAnswer> listOfWrongAnswers = new List<WrongAnswer>();

    [SerializeField] private CorrectAnswer correctAnswer = null;

    private void Start()
    {
        correctAnswer.OnCorrect += DeleteButtons;
        for (int i = 0; i < listOfWrongAnswers.Count; i++)
        {
            listOfWrongAnswers[i].OnWrong += DeleteButtons;
        }
    }

    private void DeleteButtons()
    {
        for (int i = 0; i < listOfWrongAnswers.Count + 1; i++)
        {
            if (i <3)
            {
                listOfWrongAnswers[i].OnWrong -= DeleteButtons;
            }
            correctAnswer.OnCorrect -= DeleteButtons;
            Destroy(listOfAnswers[i]);
        }
    }
}
