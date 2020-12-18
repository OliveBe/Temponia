using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public bool gameisPaused = false;

    public GameObject pauseMenuUI;
    
    public AudioSource music;

    public MusicCtrl controller;

    public KeyCode pausecmd;

    // Update is called once per frame
    void Update()
    {
        
            if(Input.GetKeyDown(pausecmd)){
        if(gameisPaused)
            {
                Resume();
                
            }else{
                Pause();
                
            }
        }
    }
    public void musicstart(){
        music.Play();
    }
   
       
    


    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameisPaused = false;
        Debug.Log("resume");
        music.Play();
    }
    void Pause()
    {
         pauseMenuUI.SetActive(true);
         Time.timeScale = 0f;
         Debug.Log("paused");
         gameisPaused = true;
         music.Pause();
    }
    public void lanjot()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameisPaused = false;
        Debug.Log("resume");
        music.Play();
    }

   public void backmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

}
