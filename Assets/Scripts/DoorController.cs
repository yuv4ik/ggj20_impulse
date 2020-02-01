using UnityEngine;

public class DoorController : MonoBehaviour, IPlayerInteractable
{
    AudioSource _audioSource;
    Animator _animator;

    public bool Activated { get; private set; }

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (Activated || _audioSource.isPlaying) return;

        Activated = true;
        _audioSource.Play();
        _animator.SetTrigger("open");
    }
}
