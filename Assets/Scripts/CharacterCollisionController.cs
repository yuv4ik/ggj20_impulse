using UnityEngine;

public class CharacterCollisionController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInteractable"))
        {
            other.GetComponent<IPlayerInteractable>().Interact();
        }
    }
}
