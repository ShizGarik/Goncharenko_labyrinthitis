using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Управление сценами. Уровень будет перезапущен при столкновении

public class GameManager : MonoBehaviour
{
   public PlayerMuvement movement; //Название скрипта объекта
   public float levelRestartDelay = 2F; //Через сколько секунд перезапуск уровня после столкновения

    public void EndGame() //Медот
    {
        movement.enabled = false; // Компонент PlayerMuvement будет выключен. Игрок перестанет двигаться после столкновения

        Invoke("RestartLevel", levelRestartDelay); // Перезапуск уровня 
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Перезапуск текущей сцены
    }
}
