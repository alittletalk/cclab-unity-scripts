//scene3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collect the stones with a collecting sound
public class CollectStone : MonoBehaviour
{
    public AudioSource collectSound;
      void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
    }
}
