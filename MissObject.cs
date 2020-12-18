using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissObject : MonoBehaviour
{
    
    public bool Activateable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
      
            if(Activateable)
            {
                gameObject.SetActive(false); 

                MusicCtrl.instance.NoteHit();
            }
    }
     private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Activator")    
        {
            Activateable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Activator")    
        {
            Activateable = false;
        }
    }
   
}
