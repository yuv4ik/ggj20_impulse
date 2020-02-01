using UnityEngine;

public class LevelController : MonoBehaviour, IPlayerInteractable
{
    public bool Activated => throw new System.NotImplementedException();

    public void Interact()
    {
        ImpulseSceneManager.Load3DRoom();
    }
}
