using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audiosource;
    
   public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
        _audiosource.Play();
    }

    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
}
