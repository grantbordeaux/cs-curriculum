using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Grants_Scripts
{
    public class HUD : MonoBehaviour

    {
        public static HUD hud;
        public TextMeshProUGUI coinText;
        public TextMeshProUGUI healthMesh;
        public int coins = 0;
        public int health;
        public int maxhealth = 9;


        private void Awake()
        {
            if (hud != null && hud != this)
            {
                Destroy(gameObject);
            }
            else
            {
                hud = this;
                DontDestroyOnLoad(gameObject);
            }
        }


        void Update()
        {
            coinText.text = $"coins: {coins}";
            healthMesh.text ="health: " + health.ToString();
        }



    }
}