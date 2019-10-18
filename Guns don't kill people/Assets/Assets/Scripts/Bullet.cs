using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rb2d;

    private void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            direction = Input.mousePosition - transform.position;
            direction *= speed;

            rb2d.AddForce(direction);
        }
    } 
}
