﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelUp4 : MonoBehaviour
{
    public void OnTriggerEnter(Collider finish)
    {
        // reload the scene
        SceneManager.LoadScene("Level4");
    }
}
