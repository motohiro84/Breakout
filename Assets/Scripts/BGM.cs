using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        if (Level.mode == 1)
        {
            audioSource.clip = Resources.Load("SoundEffects/easy") as AudioClip;
            audioSource.Play ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
