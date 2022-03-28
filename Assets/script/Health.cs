using UnityEngine;

namespace Quest
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxHealth; // максимальное здоровье
        private float curHealth; // Ќынешнее здоровье


        private void Awake()
        {
            curHealth = maxHealth;
        }

        public void HitBox(float bonusHealth)
        {
            curHealth += bonusHealth;

            if (curHealth > maxHealth)
            {
                curHealth = maxHealth;
            }
        }
        public void Hit(float damage)
        {
            curHealth -= damage; // вычитает здоровье при ударе
            if (curHealth <= 0) // при здоровье равному нулю
            {
                Die();
            }
        }
        private void Die()
        {
            gameObject.SetActive(false); //выключение объекта
        }
    }
}
