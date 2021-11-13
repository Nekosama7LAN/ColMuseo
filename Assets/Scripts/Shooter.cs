using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform cam;
    public LayerMask whatCanShoot;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, Mathf.Infinity, whatCanShoot ))
        {
            if(hit.collider)
            {
                print(hit.collider.name);
            }
        }
    }
}
