using UnityEngine;

namespace Quest
{
    public class HealthBox : MonoBehaviour
    {
        [SerializeField] private float health;

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.TryGetComponent(out Health healthBox))
            {
                healthBox.HitBox(health);

                Destroy(gameObject, 0.05f);
            }
        }
    }
}
