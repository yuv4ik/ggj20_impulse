using UnityEngine;

public class CharacterCollisionController : MonoBehaviour
{
    bool _showHint;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WrongDecision"))
        {
            other.GetComponent<IWrongDecision>().Make();
        }
    }

    IPlayerInteractable _playerInteractable;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log($"OnCollisionEnter => {other.gameObject.tag}");
        if (other.gameObject.CompareTag("PlayerInteractable"))
        {
            _showHint = true;
            _playerInteractable = other.gameObject.GetComponent<IPlayerInteractable>();
        }
    }

    void Update()
    {
        if (_playerInteractable != null && Input.GetKey(KeyCode.E))
        {
            _playerInteractable.Interact();
        }
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log($"OnCollisionExit => {other.gameObject.tag}");
        if (other.gameObject.CompareTag("PlayerInteractable"))
        {
            _showHint = false;
            _playerInteractable = null;
        }
    }

    void OnGUI()
    {
        if (!_showHint) return;

        var _hintStyle = GUI.skin.GetStyle("Label");
        _hintStyle.alignment = TextAnchor.UpperCenter;
        _hintStyle.fontStyle = FontStyle.Bold;
        _hintStyle.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "\"E\"", _hintStyle);
    }
}
