using UnityEngine;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public event Action OnCorrect;
    public event Action OnSound;

    [SerializeField] private GameObject respuestaIncorrecta1;
    [SerializeField] private GameObject respuestaIncorrecta2;
    [SerializeField] private GameObject respuestaIncorrecta3;


    public void BotonCorrecto()
    {
        print("Correcto");
        OnCorrect?.Invoke();
        OnSound?.Invoke();
        DeleteButtons();

    }


    private void OnMouseDown()
    {
        print("funca");
        BotonCorrecto();

    }

    private void DeleteButtons()
    {
        respuestaIncorrecta1.SetActive(false);
        respuestaIncorrecta2.SetActive(false);
        respuestaIncorrecta3.SetActive(false);
        this.gameObject.SetActive(false);

    }

}
