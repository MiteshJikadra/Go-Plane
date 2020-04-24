using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
       

    private Vector3 Cameraoffset;

    [Range(0.01f,1.0f)]
    public float SmoothFactor = 0.5f;

    public static CameraFollow CF;
   
    private void Awake()
    {
        CF = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //cam = GetComponent<Camera>();
        Cameraoffset = transform.position - PlainManager.PM.posPlain.position;
    }

    // Update is called once per framez
    void LateUpdate()
    {
        //Vector3 screenPos = cam.WorldToScreenPoint(t.position);
        //Debug.Log("target is " + screenPos.x + " pixels from the left");

        if (PlainManager.PM.curentpalin != null)
        {
            Vector3 newpos = PlainManager.PM.curentpalin.position + Cameraoffset;
            transform.position = Vector3.Slerp(transform.position, newpos, SmoothFactor);
        }
        
    }
    public void camerafollow()
    {
        
    }
}
