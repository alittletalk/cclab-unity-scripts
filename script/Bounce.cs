//scene1
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//question: how can I make the object bounce from the position I set, but not bounce from the 0?
public class Bounce : MonoBehaviour
{
    
    public float height;
    public float speed;
    public float offset;

    public float amplitude;
    void Update()
    {

        Vector3 newPosition = new Vector3(transform.position.x,
        
            height * Mathf.Sin(speed * Time.frameCount + offset),
            transform.position.z);
        transform.position = newPosition;
    }

}
