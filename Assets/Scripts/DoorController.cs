using UnityEngine;

public class DoorController : MonoBehaviour, IPlayerInteractable
{
    // TODO: Show open animation
    // TODO: Restart the level

    AudioSource _audioSource;
    bool _isOpened;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        if (_isOpened || _audioSource.isPlaying) return;

        _isOpened = true;
        _audioSource.Play();
    }
}
