using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Pregunta1Manager pregunta = null;

    public Text score;
    int counter = 0;

    void Start()
    {
        score.text = counter.ToString();
        pregunta.OnCorrect += AumentoPuntos;
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
