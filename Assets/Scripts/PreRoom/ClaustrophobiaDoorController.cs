using UnityEngine;

public class ClaustrophobiaDoorController : MonoBehaviour, IPlayerInteractable
{
    public bool Activated => throw new System.NotImplementedException();

    public void Interact()
    {
        ImpulseSceneManager.LoadClaustrophobiaRoom();
    }
}
