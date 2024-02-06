using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{   
    public GameObject botaoQuit;
    public LayerMask camada;
    public float forcaPulo = 5.0f;
    public float velocidade = 5.0f;
    private Rigidbody2D rb;
    private bool puloPendente = true;
    public TextMeshProUGUI lose;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float movimento = Input.GetAxis("Horizontal");

        
        Vector2 velocidadeJogador = new Vector2(movimento * velocidade, rb.velocity.y);

        rb.velocity = velocidadeJogador;
        
        

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 2, camada);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "Ground")
            {

                puloPendente = true;

                if (Input.GetButtonDown("Jump") && puloPendente)
                {
                    rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
                    puloPendente = false;
                }
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido tem uma "tag" específica
        if (collision.gameObject.tag == "BulletEnemy")
        {
            // Faça algo quando ocorrer a colisão
            

            Debug.Log("Meu pau no teu cu rose");
            Time.timeScale = 0;
            lose.text = "GAME OVER";
            botaoQuit.SetActive(true);
            
        }
    }
}
