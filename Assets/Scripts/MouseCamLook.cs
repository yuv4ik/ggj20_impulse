using System;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    [SerializeField]
    float _sensitivity = 5.0f, _smoothing = 2.0f;

    // the chacter is the capsule
    GameObject _character;
    // get the incremental value of mouse moving
    Vector2 _mouseLook;
    // smooth the mouse moving
    Vector2 _smoothV;

    void Awake()
    {
        _character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // md is mosue delta
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(_sensitivity * _smoothing, _sensitivity * _smoothing));
        // the interpolated float result between the two float values
        _smoothV.x = Mathf.Lerp(_smoothV.x, md.x, 1f / _smoothing);
        _smoothV.y = Mathf.Lerp(_smoothV.y, md.y, 1f / _smoothing);
        // incrementally add to the camera look
        _mouseLook += _smoothV;

        // vector3.right means the x-axis
        transform.localRotation = Quaternion.AngleAxis(-_mouseLook.y, Vector3.right);
        _character.transform.localRotation = Quaternion.AngleAxis(_mouseLook.x, _character.transform.up);
    }
}
