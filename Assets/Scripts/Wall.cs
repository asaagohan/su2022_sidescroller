using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject text;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if(collision.gameObject.tag == "Player")
        //{
            //text.SetActive(true);
        //}
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            text.SetActive(true);
        }
    }
}
