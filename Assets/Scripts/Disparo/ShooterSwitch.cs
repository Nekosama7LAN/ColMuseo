using UnityEngine;

public class ShooterSwitch : MonoBehaviour
{
    [SerializeField] private Shooter shooter;

    private void OnTriggerEnter(Collider other)
    {
        shooter.counter = 1;
    }
}
