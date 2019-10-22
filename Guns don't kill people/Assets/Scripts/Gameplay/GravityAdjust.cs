using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAdjust : MonoBehaviour
{
    public int gravityScaleOnHit;
    public Rigidbody2D rb2d;

    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();      
    }

    public void OnCollisionEnter2D()
    {
        rb2d.gravityScale = gravityScaleOnHit;
    }
}
