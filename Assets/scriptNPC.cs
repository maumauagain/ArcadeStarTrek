using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class scriptNPC : MonoBehaviour {
    private float altura;
    public float velocidade = 5;
    private Rigidbody2D rbd;
    private void Start() {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -velocidade);
        altura = Camera.main.orthographicSize;
        
    }
    private void Update() {
        if(transform.position.y < -altura)
            Destroy(gameObject);
        
    }
}
