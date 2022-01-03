using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    
    private void Start(){
        
        if(!PlayerPrefs.HasKey("musicValue")){

            PlayerPrefs.SetFloat("musicValue", 1);
            LoadValues();
        }else{

            LoadValues();
        }
    }

    public void SaveVolumeButton(){

        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("musicValue", volumeValue);
        LoadValues();
    }

    void LoadValues(){

        float volumeValue = PlayerPrefs.GetFloat("musicValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
