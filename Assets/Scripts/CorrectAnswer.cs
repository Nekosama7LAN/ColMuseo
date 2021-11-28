using UnityEngine;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public event Action OnCorrect;
    [SerializeField] private GameObject correctAnswer;

    private void OnMouseDown()
    {
        OnCorrect?.Invoke();
        correctAnswer.GetComponent<AudioSource>().Play();
    }
}
