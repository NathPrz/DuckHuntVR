using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float bulletSpeed = 10f;
    public void FireBullet()
    {
        // Instantiate the bullet at the spawn point position and rotation
        GameObject spawnBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

        // Adjust the rotation of the bullet by -90 degrees
        spawnBullet.transform.Rotate(-90, 0, 0);

        // Set the velocity of the bullet
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;

        Destroy(spawnBullet, 5f);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
