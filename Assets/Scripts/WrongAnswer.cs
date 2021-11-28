using UnityEngine;
using System;

public class WrongAnswer : MonoBehaviour
{
    public event Action OnWrong;
    [SerializeField] private GameObject wrongAnswer;

    private void OnMouseDown()
    {
        OnWrong?.Invoke();
        wrongAnswer.GetComponent<AudioSource>().Play();
    }
}
