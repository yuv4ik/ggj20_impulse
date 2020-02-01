using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CongratsSFXController : MonoBehaviour
{
    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _audioSource.Play();
    }
}
