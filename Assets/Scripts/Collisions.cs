using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public GameObject menu;

    // Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Lava")
        {
            // TODO: Supress all the speed
            this.GetComponent<Transform>().position = new Vector3(10.12f, 2, -12.74f);
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        } else if (collision.gameObject.name == "Finish") {
            this.menu.SetActive(true);
        }
    }
}