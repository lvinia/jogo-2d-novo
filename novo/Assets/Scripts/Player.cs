using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public int velocidade = 10;
    private Vector2


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        direcao = new Vector2(x, y0);

        Vector2 direcao = new Vector2(x, y);

        rb.velocity = direcao.normalized * velocidade;
    }


}
