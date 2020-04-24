using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public float speed = 0.5f;
    public Renderer Re;
    //private Transform loo;
    // Start is called before the first frame update
    void Start()
    {
        //loo = GameObject.FindGameObjectWithTag("Missile").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time*speed,0);
        Re.material.mainTextureOffset = offset;
        
        //warnig simbol missile side gendrate
        //if (missileGendrate.MG.posalert != null)
        //{
        //    transform.up = -missileGendrate.MG.posalert.up;
        //}

    }
}
