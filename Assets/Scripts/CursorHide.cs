using UnityEngine;

public class CursorHide : MonoBehaviour
{
    [SerializeField] private Gamemanager gamemanager;

    private void Awake()
    {
        CursorLocked();

    }

    void Start()
    {
        gamemanager.OnPause += CursorUnlocked;
        gamemanager.OnContinue += CursorLocked;
    }

    void CursorLocked()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void CursorUnlocked()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
