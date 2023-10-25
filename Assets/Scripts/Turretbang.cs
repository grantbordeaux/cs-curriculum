using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turretbang : MonoBehaviour
{

    public GameObject bulletPrefab;
    private Collider2d target = null;
    private float og_time = 3;
    private float timer = 0;
    private bool IsOn = false;

    void Start()
    {
        timer = og_time;
    }
        
        
    void Update()
    {
        if (IsOn)
        {
            timer -= Time.deltaTime;
            if (0 >= timer)
            {
                if (target != null)
                {
                    timer = og_time;
                    Instantiate(bulletPrefab, transform.position, Quanternion.identity);
                }
            }
        }
            
    }

    public void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = other;
            IsOn = true;
        }
    }

    public void OnTriggerExit2D(Colllider2D other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            IsOn = false;
        }
    }
    
}
