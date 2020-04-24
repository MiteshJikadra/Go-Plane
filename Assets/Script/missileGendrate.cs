using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileGendrate : MonoBehaviour
{
    public GameObject prefeb;
    public GameObject prefeb2;
    public Transform pos;
    public Transform pos2;
    public static missileGendrate MG;
    //public GameObject prefebAlert;
    public Transform posalert;
    public GameObject quad;

    

    private void Awake()
    {
        MG = this;
    }
    void Start()
    {  
        //Instantiate(prefeb,pos.transform.position,Quaternion.identity,pos);
        //MissileManager.MM.missilegendreter();
    }

    
    void Update()
    {
       
        //if (PlainManager.PM.curentpalin != null)
        //{
        //    Vector3 newpos = (GameObject.FindGameObjectWithTag("Missile").gameObject).transform.position - PlainManager.PM.curentpalin.position;
        //    Debug.Log(newpos);   
        //}
    }
    IEnumerator gendrate()
    {
        while (true)
        {
            posalert=Instantiate(prefeb, pos.transform.position, Quaternion.identity, pos).transform;
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator gendrate2()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(prefeb2, pos2.transform.position, Quaternion.identity, pos2);    
        }
    }
    public void StopCor()
    {
        StopAllCoroutines();
    }
    public void MissileG()
    {
        StartCoroutine(gendrate());
        StartCoroutine(gendrate2());   
    }
    
    public void MissileStop()
    {
        for (var i = transform.childCount; i-- > 0;)
        { 
           Destroy(transform.GetChild(i).gameObject);
        }    
    }  
}
