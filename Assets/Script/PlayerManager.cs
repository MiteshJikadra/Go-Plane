using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManager;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float speed;
    private float screenWidth;
    public float moveSpeed;
    private GameObject Scorecanvas;
    private GameObject nightmode;
    //private GameObject quad;

    //private Transform look;
    
    private Rigidbody2D rb;
 
    void Start()
    {
         Scorecanvas = GameObject.FindGameObjectWithTag("Score").gameObject;
         nightmode = GameObject.FindGameObjectWithTag("Night").gameObject;
        //quad = GameObject.FindGameObjectWithTag("Quad").gameObject;
        //look = GameObject.FindGameObjectWithTag("Missile").transform;

        //GameoverPanal = GameObject.FindGameObjectWithTag("PanalG").gameObject;

        //ani = GetComponent<Animator>();
        //playergendreter();
        screenWidth = Screen.width / 2;
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        //transform.LookAt(look);
        touchControll();
       
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;
    }
    void touchControll()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < screenWidth)
            {
                transform.Rotate(0,0,speed*Time.deltaTime);
            }
            else if (touch.position.x > screenWidth)
            {
                transform.Rotate(0,0,-speed*Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        // GameoverPanal.SetActive(true);
        missileGendrate.MG.StopCor();   
        missileGendrate.MG.MissileStop();
        Destroy(gameObject);
        UIManager.Instance.ChangeScreen(SceneName.GameOverCanvas);
        ScoreManager.sm.Score = 0;
        ScoreManager.sm.TScore.text = ScoreManager.sm.Score.ToString();
        Scorecanvas.SetActive(false);
        nightmode.SetActive(false);
        missileGendrate.MG.quad.SetActive(true);
        
        
    }
}