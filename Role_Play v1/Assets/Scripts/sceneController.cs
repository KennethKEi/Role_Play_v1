using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour
{
    private SimpleSampleCharacterControl _character;
    [SerializeField] AudioClip heyLookHere;
    [SerializeField] AudioClip intro;
    [SerializeField] AudioSource audioSource;
    private int _haveLooked = 0;

    public void Awake()
    {
       _character = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<SimpleSampleCharacterControl>();
       _character.GetComponent<Animator>().enabled = false;
    }

    private void Start()
    {
        StartCoroutine(HeyLook());
    }




    // Update is called once per frame
    void Update()
    {
      
    }

    private IEnumerator HeyLook()
    {
        while (_haveLooked <=0)
        {
            _character.GetComponent<Animator>().enabled = true;
            _character.GetComponent<Animator>().Play("Wave");
            audioSource.PlayOneShot(heyLookHere);
            yield return new WaitForSeconds(3.0f);
        }
    }

    public void HaveLooked()
    {
        _haveLooked = 1;
        audioSource.PlayOneShot(intro);

    }
}
