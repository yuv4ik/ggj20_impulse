using UnityEngine;

public class CongratsController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            ImpulseSceneManager.LoadPreRoom();
        }
    }
}
