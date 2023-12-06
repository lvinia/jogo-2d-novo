using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 direcao;
    public int velocidade = 10;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        direcao = Random.insideUnitCircle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direcao = Vector2.Reflect(direcao, collision.contacts[0].normal);
    }
    private void Update()
    {
        rb.velocity = direcao.normalized * velocidade;
    }
}

    


