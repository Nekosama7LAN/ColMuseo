using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] GravityRoomEnter Collider = null;
    [SerializeField] GravityRoomExit ColliderSalida = null;

    [SerializeField] Controles Player = null;




    void Start()
    {
        ColliderSalida.OnExit += NormalizarGravedad;
        Collider.OnEnter += CambioGravedad;
    }

    void Update()
    {
        
    }

    void CambioGravedad()
    {
        Player.gravityScale = -2f;
    }

    void NormalizarGravedad()
    {
        Player.gravityScale = -20;
    }
}
