using UnityEngine;

public class CicleDayAndNight : MonoBehaviour
{
    private int rotationScale = 1;

    void Update()
    {
        CicleDay();
    }

    private void CicleDay()
    {
        transform.Rotate(rotationScale * Time.deltaTime, 0, 0);
    }
}
