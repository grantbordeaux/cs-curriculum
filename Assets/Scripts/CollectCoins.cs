using System;
using UnityEditor;
using UnityEngine;

namespace Grants_Scripts
{
    public class CollectCoins : MonoBehaviour
    {
        HUD hud;

        private void Start()
        {
            hud = GameObject.FindObjectOfType<HUD>();
        }

       private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                hud.coins++;
                Destroy(collision.gameObject);
            }

            else if (collision.gameObject.CompareTag("KewlCoin"))
            {
                hud.coins += 2;
                Destroy(collision.gameObject);
            }

            {
                hud.coins++;
                hud.coins++;
                Destroy(collision.gameObject);
            }
        }









    }
}