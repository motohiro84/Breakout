using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip sound01;
    public AudioClip sound02;
    private Sound soundClip;

    void Awake()
    {

        if (Level.mode == 3)
        {
            soundClip = GameObject.Find("Ball").GetComponent<Sound>();
            soundClip.sound01 = Resources.Load("SoundEffects/ken") as AudioClip;
        }
    }

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.tag == "sound" )
        {
            AudioSource.PlayClipAtPoint(sound01, Camera.main.transform.position);
        }
        if ( other.gameObject.name == "sitakabe" )
        {
            AudioSource.PlayClipAtPoint(sound02, Camera.main.transform.position);
        }
    }
}