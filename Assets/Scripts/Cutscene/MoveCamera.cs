using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float moveSpeed = -1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;

        
        float newY = currentPosition.y + moveSpeed * Time.deltaTime;

        
        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);
    
        
    }
}
