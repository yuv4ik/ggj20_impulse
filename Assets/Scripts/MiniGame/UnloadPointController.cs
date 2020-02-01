using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class UnloadPointController : MonoBehaviour
{
    [SerializeField]
    List<Sprite> _sprites;

    [SerializeField]
    int _maxLoads = 3;

    [SerializeField]
    SnakeController _snakeController;

    int _spriteIndex;

    SpriteRenderer _spriteRenderer;

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateSprite();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!_snakeController.IsLoaded) return;
            if (_spriteIndex >= _maxLoads) return;

            _spriteIndex++;
            UpdateSprite();
        }
    }

    void UpdateSprite() => _spriteRenderer.sprite = _sprites[_spriteIndex];
}
