using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    private GameObject Player;

    public float SpeedRotation = 1;
    public float targetHeight = 2f;
    public float distance = 2.8f;
    public float maxDistance = 10;
    public float minDistance = 0.5f;
    public float xSpeed = 250f;
    public float ySpeed = 120f;
    public float yMinLimit = -40;
    public float yMaxLimit = 80;
    public float zoomRote = 20;
    public float rotationDampening = 3f;

    private float x = 0f;
    private float y = 0f;
    public bool isTalking = false;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    void LateUpdate()
    {
        if (!target)
            return;

        if (Input.GetMouseButton(1) || (Input.GetMouseButton(1))) //
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
        }
        else if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {

        }

        distance -= (Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime) * zoomRote * Mathf.Abs(distance);
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        y = ClampAngle(y, yMinLimit, yMaxLimit);

        Quaternion rotation = Quaternion.Euler(y, x, 0);
        transform.rotation = rotation;

        Vector3 position = target.position = (rotation * Vector3.forward * distance + new Vector3(0, -targetHeight, 0));
        transform.position = position;

        RaycastHit hit;
        Vector3 trueTargetPosition = target.transform.position - new Vector3(0, -targetHeight, 0);
        if (Physics.Linecast(trueTargetPosition, transform.position, out hit))
        {
            float tempDistance = Vector3.Distance(trueTargetPosition, hit.point) - 0.28f;
            position = target.position - (rotation * Vector3.forward * tempDistance + new Vector3(0, -targetHeight, 0));
            transform.position = position;
        }
    }
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}