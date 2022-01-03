using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSwitch : MonoBehaviour
{
    public AudioClip song1;
    public AudioClip song2;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySongOne(){
        
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = song1;
        audioSource.Play();
    }

    public void PlaySongTwo(){
        
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = song2;
        audioSource.Play();
    }
}
