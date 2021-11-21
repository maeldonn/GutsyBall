using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private const float SPEED = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        // this.GetComponent<Rigidbody>().mass = this.GetComponent<Rigidbody>().mass * 1/GameManager.instance.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(SPEED, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(-SPEED, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, -SPEED);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, SPEED);
        }
    }
}
