//scene3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// for the STONE:0 on the top left, count how many stones the players pick
public class ScoringSystem : MonoBehaviour
{
   public GameObject scoreText;
   public static int theScore;
   
    void Update()
    {
        scoreText.GetComponent<Text>().text="STONE:"+theScore;
        
    }

    
  
}
