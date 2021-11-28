using UnityEngine;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public event Action OnCorrect;

    private void OnMouseDown()
    {
        OnCorrect?.Invoke();
        this.GetComponent<AudioSource>().Play();
    }
}
