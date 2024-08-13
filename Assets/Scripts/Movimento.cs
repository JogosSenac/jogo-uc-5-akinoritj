using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    public bool isJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }
}
