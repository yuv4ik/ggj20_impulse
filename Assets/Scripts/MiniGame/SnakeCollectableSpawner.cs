﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeCollectableSpawner : MonoBehaviour, ISpawner
{
    [SerializeField]
    int _maxObjectsToSpawn = 3;

    [SerializeField]
    GameObject _prefab;

    [SerializeField]
    List<Vector3> _positions;

    [SerializeField]
    TimerController _timerController;

    [SerializeField]
    AudioSource _bgAudioSource;

    int _spawnCounter;

    void Awake()
    {
        Spawn();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void Spawn()
    {
        if (_spawnCounter >= _maxObjectsToSpawn)
        {
            _timerController.Stop();
            if (ImpulseSceneManager.IsGameOverLoaded()) return;
            _bgAudioSource.Stop();
            ImpulseSceneManager.LoadCongrats();
            return;
        }
        _spawnCounter++;
        Instantiate(_prefab, _positions[Random.Range(0, _positions.Count)], Quaternion.identity);
    }
}
