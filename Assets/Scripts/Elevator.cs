using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Vector3 Initpos;
    [SerializeField] Vector3 DestPos;
    private Vector3 Finalpos;
    public float counter = 5;

    public float speed = 0;
    void Update()
    {
        PlataformUp();
    }

    private void PlataformUp()
    {
        if (counter < 5f)
        {
            Initpos = transform.position;
            Finalpos = Initpos + DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;
            counter = counter + 1 * Time.deltaTime;
        }
    }
}