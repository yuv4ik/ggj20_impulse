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

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("PlayerInteractable"))
        {
           
            _showHint = true;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerInteractable") && Input.GetKey(KeyCode.E))
        {
            other.gameObject.GetComponent<IPlayerInteractable>().Interact();
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerInteractable"))
        {
            _showHint = false;
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
