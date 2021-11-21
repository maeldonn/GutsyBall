﻿using UnityEngine;
 
 public class Music : MonoBehaviour
 {
     private AudioSource _audioSource;

     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
         _audioSource = GetComponent<AudioSource>();
     }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<AudioSource>().volume = GameManager.instance.GetVolume();
    }
 
     public void PlayMusic()
     {
         if (_audioSource.isPlaying) return;
         _audioSource.Play();
     }
 
     public void StopMusic()
     {
         _audioSource.Stop();
     }
 }