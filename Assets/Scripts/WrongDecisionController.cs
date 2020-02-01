using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongDecisionController : MonoBehaviour, IWrongDecision
{
    [SerializeField]
    WallsController _wallsController;

    public void Make()
    {
        if (ImpulseSceneManager.IsGameOverLoaded()) return;

        _wallsController.StopMoving();
        ImpulseSceneManager.LoadGameOver();
    }
}
