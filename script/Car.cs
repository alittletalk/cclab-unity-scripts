//scene1/2/3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//question: How can I make the first person controller collide with this moving balls and create reactions， like sound or back to the origin?
//the balls just pass through the controller
public class Car : MonoBehaviour
{
    public float Speed = 5f;

    private Vector3 _startingPosition;


    void Start()
    {
       
        _startingPosition = transform.position;
    }

    void Update()
    {
      
        transform.Translate(Vector3.left * Speed * Time.deltaTime);

    }

    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "Wall" ||
            other.gameObject.CompareTag("Wall"))
        {
            transform.position = _startingPosition;
        }
    }


}













