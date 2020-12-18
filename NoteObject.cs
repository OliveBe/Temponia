using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private bool Activateable;
    private bool Miss = false;
    private bool Missable = true;
    public KeyCode btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(btn))
        {
            if(Activateable)
            {
                gameObject.SetActive(false); 

                MusicCtrl.instance.NoteHit();
            }
        }else if(Missable)
        {
            if(Miss)
            {
                  gameObject.SetActive(false); 

                MusicCtrl.instance.NoteMiss();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Activator")    
        {
            Activateable = true;

        }
        else if(other.tag == "Collider")    
        {
            Miss = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Activator")    
        {
            Activateable = false;
        }
        else if(other.tag == "Collider")    
        {
            Miss = false;

        }
    }
}
