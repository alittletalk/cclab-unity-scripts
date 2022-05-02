//scene2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 //this script is for trigger sound when I walk around the scene and touch the male body
 
public class soundTrigger : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound, 1f);
           //question: the sound was too low to hear, and if I change the "triggerSound,1f" above, the sound would be trembling,what should I do?

        }
    }
}