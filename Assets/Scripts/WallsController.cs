using UnityEngine;

public class WallsController : MonoBehaviour
{
    [SerializeField]
    GameObject _leftWall, _rightWall/*, _topWall*/, _bottomWall, _character;

    [SerializeField]
    float _movementSpeed, _playerOffset;

    AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_leftWall.transform.position.z + _playerOffset < _character.transform.position.z)
        {
            _leftWall.transform.position += new Vector3(0, 0, 1 * _movementSpeed * Time.deltaTime);
        } else
        {
            _audioSource.Stop();
        }

        if (_rightWall.transform.position.z - _playerOffset > _character.transform.position.z)
        {
            _rightWall.transform.position += new Vector3(0, 0, -1 * _movementSpeed * Time.deltaTime);
        }

        //if (_topWall.transform.position.x + _playerOffset < _character.transform.position.x)
        //{
        //    _topWall.transform.position += new Vector3(1 * _movementSpeed * Time.deltaTime, 0, 0);
        //}

        if (_bottomWall.transform.position.x - _playerOffset > _character.transform.position.x)
        {
            _bottomWall.transform.position += new Vector3(-1 * _movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
