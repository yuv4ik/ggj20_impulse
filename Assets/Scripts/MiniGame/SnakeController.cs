using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SnakeController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 2.0f;
    [SerializeField]
    Sprite _empty, _loaded;

    SpriteRenderer _spriteRenderer;

    public bool IsLoaded { get; private set; }

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = Input.mousePosition;
        FaceMouse(pos);
        FollowMouse(pos);
    }

    void FollowMouse(Vector3 pos)
    {
        pos.z = transform.position.z - Camera.main.transform.position.z;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = Vector3.MoveTowards(transform.position, pos, moveSpeed * Time.deltaTime);
    }

    void FaceMouse(Vector3 pos)
    {
        pos = Camera.main.ScreenToWorldPoint(pos);

        var direction = new Vector2(
            pos.x - transform.position.x,
            pos.y - transform.position.y);

        transform.up = direction;
    }

    public void Collect()
    {
        IsLoaded = true;
        _spriteRenderer.sprite = _loaded;
    }

    public void Unload()
    {
        IsLoaded = false;
        _spriteRenderer.sprite = _empty;
    }
}
