using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Vector2 bulletSpeed;
    void Start()
    {
        
    }

 
    void Update()
    {
        transform.Translate((Vector3)(translation: bulletSpeed * Time.deltaTime));
    }
    private void OnTriggerEnter2D
    
}
