using UnityEngine;

namespace Grants_Scripts
{
 

    public class HealthManager: MonoBehaviour

    { 
        
        bool iframes = false;
        HUD hud;
        float timer;
        float originalTimer;
       
        

        void Start()
        {
            hud = GameObject.FindObjectOfType<HUD>();
            originalTimer = 1.5f;
            timer = originalTimer;
        }

        
        
        
        void Update()
        {
            if (iframes)
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    iframes = false;
                    timer = originalTimer;
                }
            }
        }

        private void OnCollisionEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Spikes"))
            {
                if (!iframes)
                {
                    iframes = true;
                    hud.health--;
                }
            }
        }

    }



}