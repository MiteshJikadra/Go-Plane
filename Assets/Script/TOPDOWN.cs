using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOPDOWN : MonoBehaviour
{
    public Transform bg1;
    public Transform bg2;

    private float size;
    // Start is called before the first frame update
    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 targateps = new Vector3(targate.position.x,targate.position.y,transform.position.z);
        //transform.position = Vector3.Lerp(transform.position,targateps,0.2f);

        if (transform.position.y >= bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwichingBg();
        }
        if (transform.position.y < bg1.position.y)
        {
            bg2.position = new Vector3(bg2.position.x, bg1.position.y - size, bg2.position.z);
            SwichingBg();
        }
    }
    private void SwichingBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
}
