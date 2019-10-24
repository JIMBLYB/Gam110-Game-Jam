using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHits : MonoBehaviour
{
    private int hitsTaken;

    [SerializeField]
    private int hitsNeeded = 3;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitsTaken += 1;
        if (hitsTaken >= hitsNeeded)
            
            Destroy(gameObject);
    }
}
