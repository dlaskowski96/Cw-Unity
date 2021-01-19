using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider finish)
    {
        
        SceneManager.LoadScene("Level1");
    }
}
