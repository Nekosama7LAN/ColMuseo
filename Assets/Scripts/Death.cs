using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform Target;
    public GameObject Player;
    public AudioSource SoundPlayer;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = Target.transform.position;
        SoundPlayer.GetComponent<AudioSource>().Play();
    }
}