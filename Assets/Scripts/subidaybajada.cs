using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subidaybajada : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 DestPos;
    private Vector3 Finalpos;

    public float speed = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float PosY = transform.position.y;
        print(PosY);

        if (PosY <= 12f)
        {
            Initpos = transform.position;
            Finalpos = Initpos + DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;
        }

    }
}
