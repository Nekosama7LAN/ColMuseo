using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform Target;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = Target.transform.position;
    }
}
