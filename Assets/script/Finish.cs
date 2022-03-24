using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject panelwin; //название панели

    void OnTriggerEnter (Collider other) //Когда объект сталкивается с Collider
    {
        if(other.tag == "Player") //Если Collider имеет тег Player то
        {
            panelwin.SetActive(true); //Показывает панель
            Time.timeScale = 0; //Показывает панель бесконечно
        }
    }
}
