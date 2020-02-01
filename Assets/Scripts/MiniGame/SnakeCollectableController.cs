using UnityEngine;

public class SnakeCollectableController : MonoBehaviour, ISnakeCollectable
{
    SFXController _sfXController;

    void Awake()
    {
        _sfXController = FindObjectOfType<SFXController>();
    }

    public void Collect()
    {
        _sfXController.PlayCollectSFX();
        Destroy(gameObject);
    }
}
