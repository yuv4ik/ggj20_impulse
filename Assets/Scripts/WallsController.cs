using UnityEngine;

public class WallsController : MonoBehaviour
{
    [SerializeField]
    GameObject _leftWall, _rightWall, _topWall, _bottomWall, _character;

    [SerializeField]
    float _movementSpeed, _playerOffset;

    AudioSource _audioSource;

    bool _shouldMove = true, _leftHit, _rightHit, _topHit, _bottomHit;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_shouldMove) return;

        if (_leftHit && _rightHit && _topHit && _bottomHit)
        {
            StopMoving();
            ImpulseSceneManager.Load2DRoom();
            return;
        }

        if (_leftWall.transform.position.z + _playerOffset < _character.transform.position.z)
        {
            _leftWall.transform.position += new Vector3(0, 0, 1 * _movementSpeed * Time.deltaTime);
        }
        else { _leftHit = true; }

        if (_rightWall.transform.position.z - _playerOffset > _character.transform.position.z)
        {
            _rightWall.transform.position += new Vector3(0, 0, -1 * _movementSpeed * Time.deltaTime);
        }
        else { _rightHit = true; }

        if (_topWall.transform.position.x + _playerOffset < _character.transform.position.x)
        {
            _topWall.transform.position += new Vector3(1 * _movementSpeed * Time.deltaTime, 0, 0);
        }
        else { _topHit = true; }

        if (_bottomWall.transform.position.x - _playerOffset > _character.transform.position.x)
        {
            _bottomWall.transform.position += new Vector3(-1 * _movementSpeed * Time.deltaTime, 0, 0);
        }
        else { _bottomHit = true; }

    }

    public void StopMoving()
    {
        _shouldMove = false;
        _audioSource.Stop();
    }
}
