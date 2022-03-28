using UnityEngine;

namespace Quest.Shoot
{
    public class Mina : MonoBehaviour
    {
        [SerializeField] private float speed; //скорость полета пули
        [SerializeField] private float damage = 5f; //урон

        private void FixedUpdate()
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime; // позиция пули + направление пули * скорость
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Health health)) // при столкновении с объектом
            {
                health.Hit(damage); // нанасит урон

             Destroy(gameObject, 0.05f); // объект уничтожается при нулевом здоровье
            }
        }
    }
}