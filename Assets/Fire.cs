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
        GameObject spawnBullet= Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
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
