using UnityEngine;
using System;


public class WrongAnswer : MonoBehaviour
{
    public event Action OnWrong;
    [SerializeField] private GameObject OtraRespuesta1;
    [SerializeField] private GameObject OtraRespuesta2;
    [SerializeField] private GameObject OtraRespuesta3;



    public void BotonIncorrecto()
    {
        OnWrong?.Invoke();
        DestroyButtons();
    }

    private void OnMouseDown()
    {
        BotonIncorrecto();
    }

    private void DestroyButtons()
    {
        OtraRespuesta1.SetActive(false);
        OtraRespuesta2.SetActive(false);
        OtraRespuesta3.SetActive(false);
        this.gameObject.SetActive(false);

    }
}
