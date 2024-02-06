using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyMovement : MonoBehaviour
{
    public float velocidade = 5f;
    private Transform jogador;
    private Vector2 direcao;

    void Start()
    {
        jogador = GameObject.FindGameObjectWithTag("Player").transform;
        direcao = (jogador.position - transform.position).normalized;
        //transform.Rotate(0, 0, -180);
    }

    void Update()
    {
        // Move o objeto na direção do jogador
        transform.Translate(direcao * velocidade * Time.deltaTime);
        
        if(transform.position.x < -10){
            Destroy(gameObject);
        }
    }



    
}
