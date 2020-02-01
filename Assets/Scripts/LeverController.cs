using UnityEngine;

public class LeverController : MonoBehaviour, IPlayerInteractable
{
    AudioSource _audioSource;
    WrongDecisionController _wrongDecisionController;

    public bool Activated { get; private set; }

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _wrongDecisionController = GetComponent<WrongDecisionController>();
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
            _wrongDecisionController.Make();
        }
    }
}
