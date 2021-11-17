using UnityEngine;

public class EndSound : MonoBehaviour
{
    [SerializeField] StartSound startSound;
    private void OnTriggerEnter(Collider other)
    {
        startSound.GetComponent<AudioSource>().Stop();
    }
}
