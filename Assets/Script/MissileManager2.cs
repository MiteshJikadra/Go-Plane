using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MissileManager2 : MonoBehaviour
{
    private float speed = 6f;
    private Transform targat;
    private Rigidbody2D rb;
    private float rotateSpeed = 200f;
    public GameObject explosion;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targat = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)targat.position - rb.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Instantiate(explosion,transform.position,transform.rotation);
        if (collision.gameObject.tag == "Missile")
        {
            ScoreManager.sm.AddScore();
        }
        Destroy(gameObject);
        Debug.Log("HHHHHHH");
        Instantiate(explosion, transform.position, Quaternion.identity);
        
    }
}
