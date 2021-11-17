using UnityEngine;

public class StartSound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<AudioSource>().Play();
    }
}
