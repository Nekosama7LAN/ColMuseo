using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float shootForce = 1500f;
    [SerializeField] float shootRate = 1.5f;
    [SerializeField] float shootRateTime = 0;
    public float counter = 0;
    void Update()
    {
        if (counter > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (Time.time > shootRateTime)
                {
                    GameObject newBullet;
                    newBullet = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
                    newBullet.GetComponent<Rigidbody>().AddForce(spawnpoint.forward * shootForce);
                    shootRateTime = Time.time + shootRate;

                    Destroy(newBullet, 5);
                }
            }
        }
    }
}
