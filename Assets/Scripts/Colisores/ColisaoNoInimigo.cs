using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColisaoNoInimigo : MonoBehaviour
{
    public GameObject botaoQuit;
    public TextMeshProUGUI WIN;
    public TextMeshProUGUI textLife;
    public SpriteRenderer spriteRenderer;
    public float blinkDuration = 2.0f; // Duração do efeito em segundos
    public float blinkSpeed = 1f;

    private int life = 20;

// No método Start() ou em outro local apropriado, atribua uma referência ao script
    void Start() 
    {
        textLife.text = life.ToString();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Este método é chamado quando ocorre uma colisão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido tem uma "tag" específica
        if (collision.gameObject.tag == "New tag")
        {
            
            
            // Faça algo quando ocorrer a colisão
            Damage(1);
            Debug.Log("Meu pau na sua mao");
        }
        if (collision.gameObject.tag == "Especial")
        {
            
            Damage(3);

            Debug.Log("Meu pau na sua mao ESPECIAAAAL");
        }
    }


    public void Damage(int dano){
        StartBlinking();
        life -= dano;
        textLife.text = life.ToString();
        if(life <= 0){
            Time.timeScale = 0;
            WIN.text = "PARABENS. VOCE GANHOU!";
            botaoQuit.SetActive(true);
        }
        
    }

    public void StartBlinking()
    {
            StartCoroutine(Blink());
        
    }

    private IEnumerator Blink()
    {
        for(int i = 0; i < 8; i++){
            spriteRenderer.enabled = !spriteRenderer.enabled;
        yield return new WaitForSeconds(blinkSpeed);
        }
        
        
        spriteRenderer.enabled = true;
        
    }
    
}
