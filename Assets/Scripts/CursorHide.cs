using UnityEngine;

public class CursorHide : MonoBehaviour
{
    void Start()
    {
        CursorLocked();
    }

    void CursorLocked()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
