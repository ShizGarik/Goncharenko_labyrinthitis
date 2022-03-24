using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject objbul, objwhere;
    public GameObject objclone;
    public int power;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objclone = Instantiate(objbul, objwhere.transform.position, Quaternion.identity); // обращение =  objbul(что?), objwhere.transform.position(где?), Quaternion.identity(поворот оружи€)
            objclone.GetComponent<Rigidbody>().AddForce(objwhere.transform.forward * power);// добавление силы (направление * силу)
            Debug.Log("ѕопал");
            Destroy(objclone, 0.5f); //”даление пули
        }
    }
}
