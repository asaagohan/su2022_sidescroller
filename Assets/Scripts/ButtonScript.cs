using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator BUTTON;
    public Animator dooranim;
    public GameObject DOOR;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (other.GetComponent<BoxScript>()!=null || other.tag.Equals("Player"))
        {
            BUTTON.SetBool("pressed", true);
            Debug.Log("pressed");
            dooranim.SetBool("dooractive", true);
            DOOR.GetComponent<BoxCollider2D>().enabled = false; 
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.GetComponent<BoxScript>()!=null || other.tag.Equals("Player"))
        {
            BUTTON.SetBool("pressed", false);
            Debug.Log("unpressed");
            dooranim.SetBool("dooractive", false);
            DOOR.GetComponent<BoxCollider2D>().enabled = true; 
        }
    }
}
