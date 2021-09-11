using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    private new Rigidbody rigidbody;

    [SerializeField] private int saltosDisponibles = 0;

    public int saltos = 0;

    public float speed = 10f;

    [SerializeField] private Vector3 salto;
    [SerializeField] private Vector3 gravedad;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        Control();
        CambioGravedad();
    }

    private void Movimiento()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if (hor != 0.0f || ver != 0.0f)
        {
            Vector3 dir = transform.forward * ver + transform.right * hor;

            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
        }

    }

    private void Salto()
    {

        if (Input.GetKeyDown(KeyCode.Space) && saltosDisponibles > 0)
        {

            rigidbody.velocity = salto;
            saltosDisponibles -= 1;
        }
    }

    private void Control()
    {
        Movimiento();
        Salto();
    }

    private void CambioGravedad()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Physics.gravity = gravedad;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Terreno"))
        {
            saltosDisponibles = saltos;
        }
    }
}
