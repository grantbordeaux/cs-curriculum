using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Vector2 bulletSpeed;
    
 
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime);
    }

   

}
