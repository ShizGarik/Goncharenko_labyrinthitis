using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public int health;
    public void Hurt(int damage)
    {
        print("Ouch: " + damage);
        health -= damage; ;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("Убит");
        Destroy(gameObject);
    }
}
