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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerInteractable"))
        {
            other.gameObject.GetComponent<IPlayerInteractable>().Interact();
        }
    }
}
