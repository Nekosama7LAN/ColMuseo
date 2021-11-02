using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip miSonido;
    [SerializeField] private AudioSource source;

    [SerializeField] private Score score;
    
    void Start()
    {
        score.OnCorrectSound += PlaySound;

        source = GetComponent<AudioSource>();
        source.clip = miSonido;
    }

    void PlaySound()
    {
        source.Play();
    }
}
