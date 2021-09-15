using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //Debug.DrawRay(transform.position, 10f, Color.green);
        //if (Physics.Raycast(transform.position, Vector3.forward, out hit, 10f))
        //{
            
        //}
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }
}
