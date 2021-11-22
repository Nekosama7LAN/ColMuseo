using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float TpCounter = 0;
    [SerializeField] Transform newZone;
    void Update()
    {
        RoomChange();
    }
    private void RoomChange()
    {
        if (TpCounter > 0)
        {

            transform.position = newZone.transform.position;

        }
    }
}
