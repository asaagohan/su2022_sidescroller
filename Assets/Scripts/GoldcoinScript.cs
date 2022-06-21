using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldcoinScript : MonoBehaviour
{
    public Animator coin_anim_strip_6_0;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (other.tag.Equals("Player"))
        {
            coin_anim_strip_6_0.Play("goldcoin_pickup");
            Destroy(gameObject,0.6f);
        }
    }
}
