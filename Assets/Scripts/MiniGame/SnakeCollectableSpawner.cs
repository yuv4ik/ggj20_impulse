using System.Collections.Generic;
using UnityEngine;

public class SnakeCollectableSpawner : MonoBehaviour, ISpawner
{
    [SerializeField]
    int _maxObjectsToSpawn = 3;

    [SerializeField]
    GameObject _prefab;

    [SerializeField]
    List<Vector3> _positions;

    int _spawnCounter;

    void Awake()
    {
        Spawn();
    }

    public void Spawn()
    {
        if (_spawnCounter >= _maxObjectsToSpawn)
        {
            // TODO: Trigger congratulations screen
            return;
        }
        _spawnCounter++;
        Instantiate(_prefab, _positions[Random.Range(0, _positions.Count)], Quaternion.identity);
    }
}
