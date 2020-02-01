using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongDecisionController : MonoBehaviour, IWrongDecision
{
    public void Make()
    {
        SceneManager.LoadScene(0);
    }
}
