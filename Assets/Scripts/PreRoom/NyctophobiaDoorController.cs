using UnityEngine;

public class NyctophobiaDoorController : MonoBehaviour, IPlayerInteractable
{
    public bool Activated => throw new System.NotImplementedException();

    public void Interact()
    {
        ImpulseSceneManager.LoadNyctophobiaRoom();
    }
}