using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongDecisionController : MonoBehaviour, IWrongDecision
{
    [SerializeField]
    WallsController _wallsController;

    public void Make()
    {
        if (SceneManager.GetSceneByBuildIndex(2).isLoaded) return;
        _wallsController.StopMoving();
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }
}
