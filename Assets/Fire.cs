using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private AudioSource audioSource;


    public void FireBullet()
    {
        GameObject spawnBullet= Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
        // Adjust the rotation of the bullet by -90 degrees
        spawnBullet.transform.Rotate(-90, 0, 0);
        audioSource.Play();
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
