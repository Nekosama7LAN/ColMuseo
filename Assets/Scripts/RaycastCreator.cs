using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCreator : MonoBehaviour
{
    GameObject referencia;
    
    void Start()
    {
        
    }


    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
        {
            if (hit.transform.CompareTag("Boton"))
            {

                Debug.DrawRay(transform.position, transform.forward * 10f, Color.green);

                if (Input.GetMouseButtonDown(0))
                {
                    referencia = hit.collider.gameObject;
                    //referencia.GetComponent<>()
                }

            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);

            }
        }

        
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(transform.position, transform.forward * 10f);
    //}


}
 