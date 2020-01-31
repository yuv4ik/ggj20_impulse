using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, IPlayerInteractable
{
    // TODO: Play sound
    // TODO: Show open animation
    // TODO: Restart the level

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        Debug.Log("-----> YAY door is PlayerInteractable!");
    }
}
