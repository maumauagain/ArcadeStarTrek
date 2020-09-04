using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour
{
    public GameObject npc;
    public float largura;
    // Start is called before the first frame update
    void Start()
    {
        largura = Camera.main.orthographicSize * Camera.main.aspect;
        InvokeRepeating("Respawn", 0, 1);
    }

    private void Respawn()
    {       
        float posX = Random.Range(-largura, largura);

        Vector2 posicao = new Vector2(posX, Camera.main.orthographicSize + 1);
        Instantiate(npc, posicao, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
