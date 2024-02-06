using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTexto : MonoBehaviour
{
    public Transform objetoMovel;  // Referência ao objeto que você deseja seguir

    private void Update()
    {
        if (objetoMovel != null)
        {
            // Obtém a posição do objeto a seguir
            Vector3 novaPosicao = objetoMovel.position;

            novaPosicao.y += 2f;
            // Define a posição do TextMeshPro para a nova posição
            transform.position = novaPosicao;
        }
    }
}
