using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float difficulty;
    private float volume;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public float GetDifficulty()
    {
        return this.difficulty;
    }

    public void SetDifficulty()
    {
        this.difficulty = gameObject.GetComponent<Slider>().value;
    }

    public void SetVolume()
    {
        this.volume = gameObject.GetComponent<Slider>().value;
    }
}
