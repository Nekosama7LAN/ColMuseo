using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHide : MonoBehaviour
{
    void Start()
    {
        CursorLocked();
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.LeftAlt))
    //    {
    //        CursorUnlocked();
    //    }
    //    else
    //    {
    //        CursorLocked();
    //    }
    //}

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
