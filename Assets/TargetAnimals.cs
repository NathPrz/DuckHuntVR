using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAnimals : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other)
    {
       // Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("collision on duck works");
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
