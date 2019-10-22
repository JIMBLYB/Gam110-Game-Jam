using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public bool object_Bounces;
    [SerializeField]
    private Collider2D object_Collider;

    private void Start()
    {
        if (object_Bounces)
        {
            object_Collider.isTrigger = false;
        }
        else if (!object_Bounces)
        {
            object_Collider.isTrigger = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
        
    }
}
