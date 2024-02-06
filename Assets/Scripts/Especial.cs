using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Especial : MonoBehaviour
{
    public GameObject pistola;
    public GameObject prefabToSpawn;
    private void OnEnable()
    {
        StartCoroutine(mostraPistola());
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        // Coloque aqui o código que você quer executar quando o objeto for ativado.
        Debug.Log("O especial foi ativado!");

    }

    IEnumerator mostraPistola(){
        pistola.SetActive(true);
        yield return new WaitForSeconds(2);
        pistola.SetActive(false);
        gameObject.SetActive(false);
    }

}

