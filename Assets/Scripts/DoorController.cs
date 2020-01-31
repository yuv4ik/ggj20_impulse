using UnityEngine;

public class DoorController : MonoBehaviour, IPlayerInteractable
{
    // TODO: Show open animation
    // TODO: Restart the level

    AudioSource _audioSource;
    Animator _animator;
    bool _isOpened;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (_isOpened || _audioSource.isPlaying) return;

        _isOpened = true;
        _audioSource.Play();
        _animator.SetTrigger("open");
    }
}
