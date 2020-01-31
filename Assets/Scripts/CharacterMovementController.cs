using UnityEngine;

// https://github.com/jiankaiwang/FirstPersonController
public class CharacterMovementController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    float _translation;
    float _straffe;

    // Use this for initialization
    void Start()
    {
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        _translation = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        _straffe = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        transform.Translate(_straffe, 0, _translation);

        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
