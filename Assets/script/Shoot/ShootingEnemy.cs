using UnityEngine;

namespace Quest.Shoot
{
    [RequireComponent(typeof(FindTarget))] // атрибут ЧТО ЭТО ????
    public class ShootingEnemy : MonoBehaviour
    {
        private FindTarget findTarget; //обращается к скрипту

        [SerializeField] private Transform spawnPoint; // место респавна пули
        [SerializeField] private Bullet bullletPrefab; //префаб пули
        //private Transform target;

        private float step = 0.2f; //Скорость стрельбы в сек
        private float nextShot;

        private void Start()
        {
            findTarget = GetComponent<FindTarget>();
        }

        private void Update()
        {
            if (!(findTarget.HasTarget)) { return; } //проверка настоящего времени игры

            if(!(Time.time > nextShot)) { return; }

            nextShot = Time.time + step; //заменить значение выстрела 

            ShootEnemy();
        }

        void ShootEnemy()
        {
                // откуда происходит выстрел. инстанцирование по трем осям(префаб пули, респавн пули, ориентация
                var Bullet = Instantiate(bullletPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}