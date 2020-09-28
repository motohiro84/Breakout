using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using se1;

namespace se1
{
[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    public AudioClip sound01;
    AudioSource audioSource;
    private GameObject Obj;
    private Sound soundClip;

    void Awake()
    {

        if (Level.mode == 3)
        {
            Obj = Resources.Load("Prefabs/Box", typeof(GameObject)) as GameObject;
            soundClip = Obj.GetComponent<Sound>();
            soundClip.sound01 = Resources.Load("SoundEffects/ken") as AudioClip;
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        AudioSource.PlayClipAtPoint(sound01, Camera.main.transform.position);
    }
}
}
