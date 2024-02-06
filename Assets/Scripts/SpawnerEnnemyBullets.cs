using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnnemyBullets : MonoBehaviour
{
    public GameObject prefabToSpawn;
    private bool podeAtirar = true;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AtirarPeriodicamente());
    }

    IEnumerator AtirarPeriodicamente()
    {
        yield return new WaitForSeconds(4);
        while (true) // Este loop faz com que as balas sejam disparadas continuamente
        {
            if (podeAtirar)
            {
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                podeAtirar = false;
            }

            yield return new WaitForSeconds(4);
            podeAtirar = true;
        }
    }
}
