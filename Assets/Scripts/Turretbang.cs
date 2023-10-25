using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turretbang : MonoBehaviour
{

    public GameObject bulletPrefab;
    private Collider2d target = null
    void Update()
    {
        if (target != null)
        {
            Instantiate(bulletPrefab, position new Vector3(x: 0, y:0, z:0), Quaternium.identity)
        }
            
    }

    public void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other;
        }
    }
    
}
