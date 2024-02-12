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
            gm = FindAnyObjectByType<HUD>();
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

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Spikes"))
            {
                SetHealth(-3);
                print(gm.health);

                if (!iframes)
                {
                    iframes = true;
                    hud.health--;
                }
            }
        }


        void SetHealth(int amount)
        {
            gm.health += amount;
        }

    }





}