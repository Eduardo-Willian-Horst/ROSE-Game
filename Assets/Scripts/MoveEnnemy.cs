using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnnemy : MonoBehaviour
{

    private float posicao;
    private float movement =-2f;

    // Update is called once per frame

    
    void Update()
    {
        posicao = transform.position.y;

        if(posicao > 2.63f){
            movement = -2f;
        }
        if(posicao < -2.63f){
            movement = 2f;
        }

        transform.Translate(Vector3.up * movement * Time.deltaTime);
    }



}
