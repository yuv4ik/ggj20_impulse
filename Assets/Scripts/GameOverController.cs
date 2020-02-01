using UnityEngine;

public class GameOverController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            ImpulseSceneManager.LoadPreRoom();
        }
    }
}
