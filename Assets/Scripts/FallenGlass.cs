using UnityEngine;

public class FallenGlass : MonoBehaviour
{
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rig.useGravity = true;
        }
        //if (other.CompareTag("suelo"))
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
