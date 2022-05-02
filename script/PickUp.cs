//scene1/2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   
    //one public variable
    public Transform theDest; //theDest=short for destination
    //to determine how far the object is thrown compared to its rigid body mass
    float throwForce = 600;
    void OnMouseDown()
    {
        //turn off the Gravity, if not the object will fall from our hand
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        //the object transform from its own position to our hand=theDest
        this.transform.position=theDest.position;
        //parent the object with theDest=hold it will mouse down
        this.transform.parent=GameObject.Find("Destination").transform;//theDest
    }

//inverse version, throw it or put it back
    /*void OnMouseUp()
    {
        //unlock the parent, null=nothing
        this.transform.parent=null;
        //turn on the gravity so that the object fall to the ground when we throw it
         GetComponent<Rigidbody>().useGravity = true;
         //add force so that we can throw it
          GetComponent<Rigidbody>().AddForce(transform.forward*600);
    }*/
    void OnMouseUp()
{
  //capture a reference to the parent
  Transform parentTransform = this.transform.parent;
  
  //clear the parent
  this.transform.parent = null;

  //Turn gravity back on
  GetComponent<Rigidbody>().useGravity = true;

  //Add the force from the parent's direction
  GetComponent<Rigidbody>().AddForce(parentTransform.forward * 600);
}
}