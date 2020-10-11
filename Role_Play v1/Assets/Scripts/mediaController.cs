using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediaController : MonoBehaviour
{
    private mediaHolder _mediaHolder;

    
    // Start is called before the first frame update
    void Start()
    {
        _mediaHolder = GameObject.Find("Media Holder").GetComponent<mediaHolder>();
    }

    public void ASound()
    {
        _mediaHolder.ASound();

    }
    public void BSound()
    {
        _mediaHolder.BSound();

    }
}
