using UnityEngine;

namespace Assets.Scripts.Purchase
{
    public class CoinBurst : MonoBehaviour
    {
        public ParticleSystem ParticleSystem;

        void Start()
        {
            ParticleSystem.Stop();
        }

        public void PlayParticles()
        {
            ParticleSystem.Play(); 
        }
    }
}
