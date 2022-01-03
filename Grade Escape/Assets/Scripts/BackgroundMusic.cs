using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic backgroundMusic;
    public AudioSource _as;

    void Start(){
        _as = GetComponent<AudioSource>();
    }

    void Awake(){

        if(backgroundMusic == null){

            backgroundMusic = this;
        }else{

            Destroy(gameObject);
        }
    }

    void Update(){

        if(GameObject.FindGameObjectWithTag("Player") == null){

            _as.Stop();
        }
    }
}
