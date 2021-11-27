using UnityEngine;

public class Ballon : MonoBehaviour
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
            Destroy(collision.gameObject);
    }
}
