using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageHit : MonoBehaviour
{
    public Sprite hostageHit;

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            this.GetComponent<SpriteRenderer>().sprite = hostageHit;
        }
        
    }
    
    

  
}
