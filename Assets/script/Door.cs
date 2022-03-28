using UnityEngine;

namespace Quest
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private string targetTag; //тригер объекта
        private Transform target;

        private void OnTriggerEnter(Collider other) //вход в зону видимости
        {
            if (other.tag.Equals(targetTag))//проверка объекта с которым столкнулись
            {
                target = other.transform; //вход нужного тега

                gameObject.SetActive(false);//выключение объекта
            }
        }

        private void OnTriggerExit(Collider other) //выход из зоны видимости
        {
            if (other.tag.Equals(targetTag))
            {
                target = null; //выход объекта

                gameObject.SetActive(true);//включение объекта
            }
        }
    }
}

