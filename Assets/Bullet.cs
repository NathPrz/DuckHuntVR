using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Output to the console which GameObject the bullet has collided with
        Debug.Log("Collided with: " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);
        if (other.CompareTag("Animal"))
        {
            Destroy(other.gameObject);  // Destroy the animal
            Destroy(gameObject);        // Destroy the bullet
            FindObjectOfType<MainGameManager>().OnAnimalDestroyed();
        }
    }
    // Update is called once per frame
    void Update()
        {
        
        }
}
