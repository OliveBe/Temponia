using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonctrler : MonoBehaviour
{   
    
    public void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

   public void backmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // public void ShowLoginMenu()
    // {
    //     LoginMenu.SetActive(true);
    //     loginmenubutton.SetActive(false);
    // }

    // public void backlogin()
    // {
    //     LoginMenu.SetActive(false);
    //     loginmenubutton.SetActive(true);
    // }

}
