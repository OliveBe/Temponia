using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl : MonoBehaviour
{   
    public SpriteRenderer btns;
    public Sprite idleImg;
    public Sprite activeImg;

    public KeyCode keyButton;
    // Start is called before the first frame update
    void Start()
    {
        btns = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyButton))
        {
            btns.sprite = activeImg;
        }
        if(Input.GetKeyUp(keyButton))
        {
            btns.sprite = idleImg;
        }
    }
}
