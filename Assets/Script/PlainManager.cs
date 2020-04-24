using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlainManager : MonoBehaviour
{
    public GameObject prefebPlain;
    public Transform posPlain;
    public Transform curentpalin;
    public static PlainManager PM;
    //private GameObject ScoreC;

    private void Awake()
    {
        PM = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //ScoreC = GameObject.FindGameObjectWithTag("Score").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlainGendret()
    {
        //coreC.SetActive(true);
        
        curentpalin = Instantiate(prefebPlain, posPlain.transform.position, Quaternion.identity,posPlain).transform;
       
    }
}
