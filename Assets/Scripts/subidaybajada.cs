using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subidaybajada : MonoBehaviour
{
    [SerializeReference]private float Initpos = 9;

    [SerializeReference] private float Finalpos = 12;

    [SerializeReference] private float speed = 0;

    [SerializeReference] Vector3 nuevaPosicion;

    [SerializeField] GameObject PositionReference;
    int counter = 4;

    private void Start()
    {
        nuevaPosicion = new Vector3(-22.48328f, Finalpos, 0.504017f);
    }

    void Update()
    {
        //float PosY = transform.position.y;


        //if (PosY <= 12f)
        //{

        //    Finalpos = Initpos + DestPos * Time.deltaTime * speed;
        //    transform.position = Finalpos;
        //}
        if (Input.GetKey(KeyCode.U))
        {
            Rotation();
        }

    }

    private void Rotation()
    {
        transform.position = nuevaPosicion * Time.deltaTime * speed;
    }
}