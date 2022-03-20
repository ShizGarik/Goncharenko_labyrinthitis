using UnityEngine;

public class PlayerMuvement : MonoBehaviour
{
    private GameObject Player; //Переменная игрового объекта Player
    public GameManager gm;

    public float Speed = 5; //Скорость объекта
    public float SpeedRotation = 1; //Скорость поворота объекта
    public float Jump = 6; //Сила прыжка

    void OnCollisionEnter(Collision collision) //Принимает параметр: Столкновение которое произошло
    {
        if (collision.collider.tag == "Obstacle") //С чем произошло столкновение
        {
            gm.EndGame(); //Вызов метода
            Debug.Log("Проиграл"); //Вывод в консоле
        }
    }
    void Start()
    {
        Player = (GameObject)this.gameObject; //Без использования тегов могу Присвоить этот скрипт к любому объекту
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))//Назначение клавиши для движения вперед. GetKeyDown - надо постоянно наживать на кнопку
        {
            Player.transform.position -= Player.transform.forward * Speed * Time.deltaTime; // Задаю позицию объекта по оси (x, y, z) -= Движение * заданная скорость * частота кадров в секунду
        }
        if (Input.GetKey(KeyCode.S))//Назначение клавиши для движения назад
        {
            Player.transform.position += Player.transform.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) //Поворот объекта на лево
        {
            Player.transform.Rotate(Vector3.down * SpeedRotation); // Разворот объекта по оси (x, y, z) (по трем координатам * скорость разворота)
        }
        if (Input.GetKey(KeyCode.D))//Поворот объекта на право 
        {
            Player.transform.Rotate(Vector3.up * SpeedRotation);
        }
        if (Input.GetKey(KeyCode.Space)) //Назначение кнопки для прыжка
        {
            Player.transform.position += Player.transform.up * Jump * Time.deltaTime;
        }

    }
}