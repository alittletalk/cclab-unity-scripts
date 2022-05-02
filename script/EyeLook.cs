//scene2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for the eyeballs on the head. it will move follow the player
public class EyeLook : MonoBehaviour
{
    public Transform eyeDest;
   public float speed = 5f;
    void Update()
    {
        transform.LookAt(eyeDest);
      
    }
}
