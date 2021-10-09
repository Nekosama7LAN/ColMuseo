using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]public AudioClip miSonido;
    [SerializeField]private AudioSource source;
    [SerializeField] private CorrectAnswer PreguntaCorrecta1;
    [SerializeField] private CorrectAnswer PreguntaCorrecta2;
    [SerializeField] private CorrectAnswer PreguntaCorrecta3;
    [SerializeField] private CorrectAnswer PreguntaCorrecta4;
    [SerializeField] private CorrectAnswer PreguntaCorrecta5;
    [SerializeField] private CorrectAnswer PreguntaCorrecta6;
    [SerializeField] private CorrectAnswer PreguntaCorrecta7;
    [SerializeField] private CorrectAnswer PreguntaCorrecta8;
    [SerializeField] private CorrectAnswer PreguntaCorrecta9;
    [SerializeField] private CorrectAnswer PreguntaCorrecta10;
    [SerializeField] private CorrectAnswer PreguntaCorrecta11;
    [SerializeField] private CorrectAnswer PreguntaCorrecta12;
    [SerializeField] private CorrectAnswer PreguntaCorrecta13;
    [SerializeField] private CorrectAnswer PreguntaCorrecta14;

    void Start()
    {
        PreguntaCorrecta1.OnSound += PlaySound;
        PreguntaCorrecta2.OnSound += PlaySound;
        PreguntaCorrecta3.OnSound += PlaySound;
        PreguntaCorrecta4.OnSound += PlaySound;
        PreguntaCorrecta5.OnSound += PlaySound;
        PreguntaCorrecta6.OnSound += PlaySound;
        PreguntaCorrecta7.OnSound += PlaySound;
        PreguntaCorrecta8.OnSound += PlaySound;
        PreguntaCorrecta9.OnSound += PlaySound;
        PreguntaCorrecta10.OnSound += PlaySound;
        PreguntaCorrecta11.OnSound += PlaySound;
        PreguntaCorrecta12.OnSound += PlaySound;
        PreguntaCorrecta13.OnSound += PlaySound;
        PreguntaCorrecta14.OnSound += PlaySound;
        

        source = GetComponent<AudioSource>();
        source.clip = miSonido;

    }

    void Update()
    {

    }

    void PlaySound()
    {
        source.Play();
    }
}
