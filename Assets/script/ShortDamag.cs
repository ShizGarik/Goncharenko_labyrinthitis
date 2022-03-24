using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortDamag : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(damage);
            Debug.Log("Убит");
            Destroy(gameObject);
        }
    }
}
