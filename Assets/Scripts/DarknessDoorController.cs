using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessDoorController : MonoBehaviour, IPlayerInteractable
{

    AudioSource _audioSource;
   

    public bool Activated { get; private set; }

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
      
    }

    public void Interact()
    {
        if (Activated) return;
        Activated = true;
   

        _activationTimestamp = Time.time;
        _audioSource.Play();
    }

    float _activationTimestamp;

    void Update()
    {
        if (!Activated) return;

        if (Time.time - _activationTimestamp >= _audioSource.clip.length)
        {
            Make();
        }

    }

        void Make()
    {

        ImpulseSceneManager.Load2DRoom();
    }
}
