using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Master;
    float MusicVolume = 0.5f;
    float SFXVolume = 0.5f;
    float MasterVolume = 0.5f;

    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider masterSlider;


    void Awake()
    {
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/SFX");
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master");

        if(PlayerPrefs.GetFloat("MusicVolume",  1000) != 1000)
            MusicVolume = PlayerPrefs.GetFloat("MusicVolume");

        if (PlayerPrefs.GetFloat("SFXVolume", 1000) != 1000)
            SFXVolume = PlayerPrefs.GetFloat("SFXVolume");

        if (PlayerPrefs.GetFloat("MasterVolume", 1000) != 1000)
            MasterVolume = PlayerPrefs.GetFloat("MasterVolume");

        masterSlider.value = MasterVolume;
        musicSlider.value = MusicVolume;
        sfxSlider.value = SFXVolume;
    }


    void Update()
    {
        Music.setVolume(MusicVolume);
        SFX.setVolume(SFXVolume);
        Master.setVolume(MasterVolume);
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume);
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume);
        PlayerPrefs.SetFloat("MasterVolume", MasterVolume);
    }


    public void MusicVolumeControl(float newMusicVolume)
    {
        MusicVolume = newMusicVolume;
    }

    public void SFXVolumeControl(float newSFXVolume)
    {
        SFXVolume = newSFXVolume;
    }

    public void MasterVolumeControl(float newMasterVolume)
    {
        MasterVolume = newMasterVolume;
    }
}
