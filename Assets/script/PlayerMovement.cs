using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quest
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 direction;
        private bool isRunning;

        [SerializeField] private float speed = 5; //Скорость объекта
        [SerializeField] private float runSpeed = 10; //Скорость объекта
        [SerializeField] private float jump = 6; //Сила прыжка

        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private string Jump = "Jump";
        private string run = "Run";

        private void Update()
        {
            direction.x = Input.GetAxis(horizontal);
            direction.z = Input.GetAxis(vertical);
            direction.y = Input.GetAxis(Jump);
            isRunning = Input.GetButton(run);
        }

        private void FixedUpdate()
        {
            //позиция объекта + направление * (если бежит ? использую runSpeed : если нет то Speed ) * прыжок
            transform.position += direction.normalized * (isRunning ? runSpeed : speed) * jump * Time.fixedDeltaTime;
        }
    }
}