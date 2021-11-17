using UnityEngine;

public class Welcome : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<AudioSource>().Play();
    }
}
