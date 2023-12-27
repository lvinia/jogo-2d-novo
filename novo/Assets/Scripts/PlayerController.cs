using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int velocidade = 10;
    private Vector2 direcao;
    void Start()
    {
        TryGetComponent(out rb);
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        direcao = new Vector2(x, 0).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = direcao * velocidade;
    }
}
