using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFXController : MonoBehaviour
{
    [SerializeField]
    AudioClip _sfxCollect;

    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayCollectSFX() => _audioSource.PlayOneShot(_sfxCollect, 1f);
}
