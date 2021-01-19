using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelReset :MonoBehaviour 
{
    public void OnTriggerEnter(Collider finish)
    {
        // reload the scene
        SceneManager.LoadScene("Level2");
    }
}
