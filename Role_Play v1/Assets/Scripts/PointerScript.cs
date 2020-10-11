﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audiosource;
    
    

   public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
               
    }

    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        _audiosource.Play();
    }

    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
        
    }
}
