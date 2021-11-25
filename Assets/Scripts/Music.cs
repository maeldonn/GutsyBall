using UnityEngine;
 
 public class Music : MonoBehaviour
 {
     private AudioSource _audioSource;

     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
         _audioSource = GetComponent<AudioSource>();
     }

    // Start is called before the first frame update
    void Start()
    {
        // FIXME: NPE here
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