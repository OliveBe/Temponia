using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButonAction : MonoBehaviour
{   
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void howto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void QuitGame()
    {
        Application.Quit();
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
