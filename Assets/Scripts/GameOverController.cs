using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(0);
        }
    }
}
