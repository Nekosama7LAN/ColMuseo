using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip miSonido;
    [SerializeField] private AudioSource source;

    [SerializeField] private WrongAnswer wrongAnswer = null;

    [SerializeField] private Score score;
    
    void Start()
    {
        wrongAnswer.OnWrong += PlayWrongAnswerSound;

        score.OnCorrectSound += PlaySound;

        source = GetComponent<AudioSource>();
        source.clip = miSonido;
    }

    private void PlayWrongAnswerSound()
    {
        
    }

    void PlaySound()
    {
        source.Play();
    }
}
