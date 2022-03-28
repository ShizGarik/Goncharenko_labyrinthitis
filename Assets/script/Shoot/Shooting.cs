using UnityEngine;

namespace Quest.Shoot
{
    [RequireComponent(typeof(FindTarget))] // атрибут ЧТО ЭТО ????
    public class Shooting : MonoBehaviour
    {
        private FindTarget findTarget; //обращается к скрипту

        private string fire1 = "Fire1";
        private string fier2 = "Fire2";

        [SerializeField] private Transform spawnPoint; // место респавна пули
        [SerializeField] private Bullet bulletPrefab; //префаб пули
        [SerializeField] private Mina minaPrefab;
        //private Transform target;

        private float step = 0.2f; //Скорость стрельбы в сек
        private float nextShot;

        private void Update()
        {
            if (!(Time.time > nextShot)) { return; } //проверка настоящего времени игры
            
            nextShot = Time.time + step; //заменя значение выстрела 

            Shoot();
        }

        void Shoot()
        {
            if (Input.GetButton(fire1)) // Назначение кнопки выстрела
            {
            // откуда происходит выстрел. инстанцирование по трем осям(префаб пули, респавн пули, ориентация
                var Bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation); 
            }

            if (Input.GetButtonUp(fier2))
            {
                var Mina = Instantiate(minaPrefab, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}





