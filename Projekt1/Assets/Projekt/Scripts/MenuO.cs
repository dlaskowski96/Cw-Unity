using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuO : MonoBehaviour
{

   

    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }



    public void ExitButton()
    {
        Application.Quit();
    }

}

