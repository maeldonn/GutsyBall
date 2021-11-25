using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public GameObject menu;
  private float _speed = 2.5f;

  // Start is called before the first frame update
  void Start()
  {
    // TODO: Ajuster la difficulté
    // this.GetComponent<Rigidbody>().mass = this.GetComponent<Rigidbody>().mass * GameManager.instance.GetDifficulty() * 10;
    // this._speed = 2.5f * GameManager.instance.GetDifficulty() * 10;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      Debug.Log(this._speed);
      this.GetComponent<Rigidbody>().AddTorque(_speed, 0, 0);
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
      this.GetComponent<Rigidbody>().AddTorque(-_speed, 0, 0);
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      this.GetComponent<Rigidbody>().AddTorque(0, 0, -_speed);
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
      this.GetComponent<Rigidbody>().AddTorque(0, 0, _speed);
    }
    else if (Input.GetKey(KeyCode.Escape) && !this.menu.activeSelf)
    {
      this.menu.SetActive(true);
    }
  }
}


