using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject menu;
    private float _speed = 2.5f;

    void Start()
    {
      // TODO: Ajuster la difficulté
      // this.GetComponent<Rigidbody>().mass = this.GetComponent<Rigidbody>().mass * GameManager.instance.GetDifficulty() * 10;
      // this._speed = 2.5f * GameManager.instance.GetDifficulty() * 10;
    }

    void Update()
    {
        // Move forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log(this._speed);
            this.GetComponent<Rigidbody>().AddTorque(_speed, 0, 0);
        }

        // Move backward
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(-_speed, 0, 0);
        } 

        // Turn right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, -_speed);
        }

        // Turn left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().AddTorque(0, 0, _speed);
        }

        // Open pause menu
        else if (Input.GetKey(KeyCode.Escape) && !this.menu.activeSelf)
        {
            this.menu.SetActive(true);
        }
    }
}


