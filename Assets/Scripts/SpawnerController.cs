using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{

    public GameObject especial;
    public int habilitarEspecial = 0;
    public TextMeshProUGUI textoEspecial;
    private bool podeAtirar = true;
    public GameObject prefabToSpawn; // O prefab que você deseja spawnar

    void Start(){
        
    }
    void Update()
    {
        if ( podeAtirar && Input.GetKeyDown(KeyCode.K)) // Verifica se a barra de espaço foi pressionada (você pode alterar isso para qualquer outra tecla)
        {
            StartCoroutine(CreateBullet());
        }


        if(habilitarEspecial >= 5){
            textoEspecial.text = "Especial -> L";
            
            
        }

        if(habilitarEspecial>=5 && Input.GetKeyDown(KeyCode.L)){
            especial.SetActive(true);
            textoEspecial.text = "";
            habilitarEspecial = 0;
            
        }
    }

    void SpawnPrefab()
    {
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        habilitarEspecial++;
    }


    IEnumerator CreateBullet(){
        podeAtirar = false;
        SpawnPrefab();
        yield return new WaitForSeconds(2);
        podeAtirar = true;
    }
}
