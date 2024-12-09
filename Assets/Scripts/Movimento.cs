using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public bool comVida = true;
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    private Animator animPlayer;
    public bool isJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animPlayer = GetComponent<Animator>();
    }

    
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);

        if(Input.GetKey(KeyCode.D))
        {
            animPlayer.SetLayerWeight(1,1);
        }
        else
        {
            animPlayer.SetLayerWeight(1,0);   
        }

        if(Input.GetKey(KeyCode.Space))
        {
            animPlayer.SetLayerWeight(2,1);
        }
        else
        {
            animPlayer.SetLayerWeight(2, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }

        if(other.gameObject.CompareTag("Morte"))
        {
            Destroy(this.gameObject);
            
        }
    }
}
