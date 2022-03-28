using UnityEngine;

namespace Quest
{
    public class FindTarget : MonoBehaviour
    {
        [SerializeField] private string targetTag; //тригер объекта
        private Transform target;
        public Transform Target => target; //Что это??
        public bool HasTarget => target != null; // Есть таргет или нет. Если таргет не равен нулю то HasTarget ЧТО ЭТО?

        private void OnTriggerEnter(Collider other)//ловить событие. Вход в колайдер(зона видимости)
        {
            if (other.tag.Equals(targetTag))//проверка объекта с которым столкнулись
            {
                target = other.transform; //вход нужного тега
            }
        }

        private void OnTriggerExit(Collider other)//объект выходит из колайдера (зона видимости)
        {
            if (other.tag.Equals(targetTag))
            {
                target = null;
            }
        }
    }
}
