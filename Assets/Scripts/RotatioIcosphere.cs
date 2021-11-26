using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatioIcosphere : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 20f) * Time.deltaTime);
    }
}
