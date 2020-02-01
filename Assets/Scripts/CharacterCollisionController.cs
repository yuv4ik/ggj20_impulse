using UnityEngine;

public class CharacterCollisionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WrongDecision"))
        {
            other.GetComponent<IWrongDecision>().Make();
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerInteractable") && Input.GetKey(KeyCode.E))
        {
            other.gameObject.GetComponent<IPlayerInteractable>().Interact();
        }
    }
}
