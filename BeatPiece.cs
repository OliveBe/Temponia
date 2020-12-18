﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatPiece : MonoBehaviour
{
    public float beatTempo;
    public bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;    
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart)
        {
            
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
