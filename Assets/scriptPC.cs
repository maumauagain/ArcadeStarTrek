using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    public GameObject tiro;
    public float velocidade = 10;
    private Rigidbody2D rbd;
    private AudioSource som;
    private float largura;
    private float altura;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        som = GetComponent<AudioSource>();
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * velocidade;

        VerifyBorder();
        VerifyShoot();

    }

    private void VerifyShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            som.Play();
            Instantiate(tiro, transform.position, Quaternion.identity);
        }
    }

    private void VerifyBorder()
    {
        float alturaAtual = transform.position.y;
        float larguraAtual = transform.position.x;

        if (larguraAtual > largura)
            transform.position = new Vector2(-largura, alturaAtual);
        else if(larguraAtual < -largura)
            transform.position = new Vector2(largura, alturaAtual);

        if(alturaAtual > 0)
            transform.position = new Vector2(larguraAtual, 0);
        else if(alturaAtual < -altura)
            transform.position = new Vector2(larguraAtual, -altura);

    }
}
