﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SOn()
    {
        sound.SetActive(true);
        
    }
    public void SOff()
    {
        sound.SetActive(false);
    }
}
