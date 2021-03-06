using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetrain : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 DestPos;
    private Vector3 Finalpos;

    float counter = 0;
    float counterDown = 5;

    public float speed = 0;
    void Update()
    {
        UpAndDownObject();
    }

    private void UpAndDownObject()
    {
        if (counter < 1f)
        {
            Initpos = transform.position;
            Finalpos = Initpos + DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;
            counter = counter + 1 * Time.deltaTime;
            counterDown = 1f;
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
    }
}
