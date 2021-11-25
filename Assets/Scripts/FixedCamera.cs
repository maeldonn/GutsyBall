using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;

    void Start()
    {
        this._offset = new Vector3(0, 2, -3);
    }

    void FixedUpdate()
    {
        //stores the flat velocity of your player so it can put the camera always behind it
        Vector3 flatSpeed = player.GetComponent<Rigidbody>().velocity;
        flatSpeed.y = 0;

        Quaternion wantedRotation = new Quaternion(0, 0, 0, 0);

        if (flatSpeed != Vector3.zero)
        {
            float targetAngle = Quaternion.LookRotation(flatSpeed).eulerAngles.y;
            wantedRotation = Quaternion.Euler(0, targetAngle, 0);
        }

        this.GetComponent<Transform>().position = player.transform.position + (wantedRotation * _offset);
        transform.LookAt(player.transform);
    }
}