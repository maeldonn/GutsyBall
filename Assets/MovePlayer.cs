using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 0.005f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, -speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, speed);
        }
    }
}
