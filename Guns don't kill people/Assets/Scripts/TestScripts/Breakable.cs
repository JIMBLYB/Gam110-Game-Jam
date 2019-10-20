using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Breaking : MonoBehaviour
{
    public bool object_Bounces;
    [SerializeField]
    private Collider2D collider;

    private void Start()
    {
        if (object_Bounces)
        {
            collider.isTrigger = false;
        }
        else if (!object_Bounces)
        {
            collider.isTrigger = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {

    }
}
