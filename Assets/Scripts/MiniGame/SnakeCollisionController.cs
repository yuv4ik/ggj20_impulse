using UnityEngine;

public class SnakeCollisionController : MonoBehaviour
{
    [SerializeField]
    SnakeCollectableSpawner _snakeCollectablesSpawner;

    SnakeController _snakeController;

    void Awake()
    {
        _snakeController = GetComponent<SnakeController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SnakeCollectable"))
        {
            if (_snakeController.IsLoaded) return;
            other.GetComponent<ISnakeCollectable>().Collect();
            _snakeController.Collect();
        }
        else if (other.CompareTag("UnloadPoint"))
        {
            if (!_snakeController.IsLoaded) return;
            _snakeController.Unload();

            _snakeCollectablesSpawner.Spawn();
        }
    }
}
