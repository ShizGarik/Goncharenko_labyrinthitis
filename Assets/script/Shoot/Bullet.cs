using UnityEngine;

namespace Quest.Shoot
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10f; //скорость полета пули
        [SerializeField] private float damage = 1f; //урон

        private void FixedUpdate()
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime; // позиция пули + направление пули * скорость
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Health health)) // при столкновении с объектом
            {
                health.Hit(damage); // нанасит урон
            }
            Destroy(gameObject); // объект уничтожается при нулевом здоровье
        }
    }
}
