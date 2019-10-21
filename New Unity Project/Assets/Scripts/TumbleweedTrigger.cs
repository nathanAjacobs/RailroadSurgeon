﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleweedTrigger : MonoBehaviour
{
    public Animator anim;

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
            anim.SetBool("startAnimation", true);
        }
    }
}
