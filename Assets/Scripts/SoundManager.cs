using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip sonidoMoneda;
    [SerializeField] private AudioClip sonidoIncorrecto;

    [SerializeField] private AudioSource source;

    [SerializeField] private WrongAnswer wrongAnswer;

    [SerializeField] private Score score;
    
    void Start()
    {
        source = GetComponent<AudioSource>();

        score.OnWrongSound += PlayWrongAnswerSound;

        score.OnCorrectSound += PlayCorrectSound;
    }

    private void PlayWrongAnswerSound()
    {
        source.clip = sonidoIncorrecto;
        source.Play();
    }

    void PlayCorrectSound()
    {
        print("gunca");
        source.clip = sonidoMoneda;
        source.Play();
    }
}
