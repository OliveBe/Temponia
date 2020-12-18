using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicCtrl : MonoBehaviour
{
    public AudioSource music;
    public bool startMusic;
    public BeatPiece beatPiece;
    public static MusicCtrl instance;
    public int scoreNow;
    public int scoreAmount = 100;
    
    public int maxHealth = 100; 
    public int currentHealth;

    public int healAmount = 5;
    public int damageAmount = 5;

    public SliderController sliderControl;
    public Text scoreText;
    public Text MulText;

    public pausemenu pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentHealth = maxHealth;
        sliderControl.setMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if(!startMusic)
        {
            if(Input.anyKeyDown)
            {
                startMusic = true;
                beatPiece.gameStart = true;
                 
                pauseMenu.musicstart();
            }
        }
        if(currentHealth <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Game Over");
        }
    }

    

    public void NoteHit()
    {
        Debug.Log("noice");

        scoreNow += scoreAmount;
        scoreText.text = ""+ scoreNow;
        
        if(currentHealth > maxHealth)
        {
            sliderControl.setHealth(maxHealth);
        }
        else if(currentHealth < maxHealth)
        {
        currentHealth += healAmount;
        sliderControl.setHealth(currentHealth);
        }
    }

    public void NoteMiss()
    {
        Debug.Log("F");

        currentHealth -= damageAmount;
        sliderControl.setHealth(currentHealth);
    }


}
