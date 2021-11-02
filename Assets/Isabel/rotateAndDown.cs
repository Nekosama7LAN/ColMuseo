using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAndDown : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 DestPos;
    private Vector3 Finalpos;

    float counter = 0;
    float counterDown = 5;

    public float speed = 0;
    private void Start()
    {
        
    }

    void Update()
    {
        RotationOfObject();

        

        if (counter < 5f)
        {
            

            Initpos = transform.position;
            Finalpos = Initpos + DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;

            counter = counter + 1 * Time.deltaTime;
            counterDown = 5f;
        }
        else
        {
            

            Initpos = transform.position;
            Finalpos = Initpos - DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;

            counterDown = counterDown - 1 * Time.deltaTime;

            if (counterDown < 0)
            {
                counter = 0;
            }

        }
        print(counter + "counter subida");
        print(counterDown + "Bajada");
    }



    private void RotationOfObject()
    {
        transform.Rotate(new Vector3(0f, 20f, 0f) * Time.deltaTime);
    }
}
