using UnityEngine;

public class SnakeCollectableController : MonoBehaviour, ISnakeCollectable
{
    public void Collect()
    {
        Destroy(gameObject);
    }
}
