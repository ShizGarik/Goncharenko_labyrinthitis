using UnityEngine;

namespace Quest
{
    [RequireComponent(typeof(FindTarget))]
    public class LookTarget : MonoBehaviour
    {
        private FindTarget findTarget; //обращается к скрипту

        //private Transform target; // Выбор объекта по таргету
        [SerializeField] private float rotationSpeed = 5f; // скорость поворота объекта

        private void Start()
        {
            findTarget = GetComponent<FindTarget>(); //доступ к другим компонентам и указать тип
        }

        private void FixedUpdate()
        {
        // Если нет таргета то завершаю работу функции
            if (!findTarget.HasTarget) { return; }
        // найти нужный вектор направления (конечная точка вектора - начальная точка вектора)
            var direction = findTarget.Target.position - transform.position;
        // (var - динамический тип) метод: передаю нынешний поворот, угол поворота, скорость поворота
            var step = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.fixedDeltaTime, 0f);
        // Что то про поворот :-)
            transform.rotation = Quaternion.LookRotation(step);
        }
    }
}
