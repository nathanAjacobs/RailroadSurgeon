using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Master;
    float MusicVolume = 0.5f;
    float SFXVolume = 0.5f;
    float newMusicVolume;
    float newSFXVolume;

    void Awake()
    {
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Music");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/SFX");
    }


    void Update()
    {
        Music.setVolume(MusicVolume);
        SFX.setVolume(SFXVolume);

    }


    public void MusicVolumeControl(float newMusicVolume)
    {
        MusicVolume = newMusicVolume;
    }

    public void SFXVolumeControl(float newSFXVolume)
    {
        SFXVolume = newSFXVolume;
    }

}
