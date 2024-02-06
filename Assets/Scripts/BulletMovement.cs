using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * 7f * Time.deltaTime);

        if(transform.position.x > 10){
            Destroy(gameObject);
        }
    }


    
}
