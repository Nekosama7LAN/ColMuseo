using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] CorrectAnswer pregunta1 = null;
    [SerializeField] CorrectAnswer pregunta2 = null;
    [SerializeField] CorrectAnswer pregunta3 = null;
    [SerializeField] CorrectAnswer pregunta4 = null;
    [SerializeField] CorrectAnswer pregunta5 = null;
    [SerializeField] CorrectAnswer pregunta6 = null;
    [SerializeField] CorrectAnswer pregunta7 = null;
    [SerializeField] CorrectAnswer pregunta8 = null;
    [SerializeField] CorrectAnswer pregunta9 = null;
    [SerializeField] CorrectAnswer pregunta10 = null;
    [SerializeField] CorrectAnswer pregunta11 = null;
    [SerializeField] CorrectAnswer pregunta12 = null;
    [SerializeField] CorrectAnswer pregunta13 = null;
    [SerializeField] CorrectAnswer pregunta14 = null;

    public Text score;
    private int counter = 0;

    void Start()
    {
        score.text = counter.ToString();
        pregunta1.OnCorrect += AumentoPuntos;
        pregunta2.OnCorrect += AumentoPuntos;
        pregunta3.OnCorrect += AumentoPuntos;
        pregunta4.OnCorrect += AumentoPuntos;
        pregunta5.OnCorrect += AumentoPuntos;
        pregunta6.OnCorrect += AumentoPuntos;
        pregunta7.OnCorrect += AumentoPuntos;
        pregunta8.OnCorrect += AumentoPuntos;
        pregunta9.OnCorrect += AumentoPuntos;
        pregunta10.OnCorrect += AumentoPuntos;
        pregunta11.OnCorrect += AumentoPuntos;
        pregunta12.OnCorrect += AumentoPuntos;
        pregunta13.OnCorrect += AumentoPuntos;
        pregunta14.OnCorrect += AumentoPuntos;


    }


    void Update()
    {
       
    }

    private void AumentoPuntos()
    {
        counter++;
        score.text = counter.ToString();
    }


}
