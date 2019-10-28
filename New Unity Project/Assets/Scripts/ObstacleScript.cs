﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public string music = "event:/background_music";
    FMOD.Studio.EventInstance musicEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            UIupdate.gameOver = true;
            FMODUnity.RuntimeManager.PlayOneShot("event:/train_crash");
        }

    }
}
