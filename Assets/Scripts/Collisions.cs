using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public GameObject menu;

    void OnCollisionEnter(Collision collision)
    {
        // Check for a loose
        if (collision.gameObject.name == "Lava")
        {
            this.GetComponent<Transform>().position = new Vector3(10.12f, 2, -12.74f);
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        } 

        // Check for a win
        else if (collision.gameObject.name == "Finish") {
            this.menu.SetActive(true);
        }
    }
}