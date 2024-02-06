using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Enemy : MonoBehaviour
{

    public TextMeshProUGUI textLife;
    private int life = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int dano){
        life -= dano;
        textLife.text = life.ToString();
        
    }
}
