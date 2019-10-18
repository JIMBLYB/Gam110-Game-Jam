using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    public Rigidbody2D rb2d;

    private Vector2 origionalPosition;
    private Camera mainCamera;

    private void Start()
    {
        origionalPosition = transform.position;
        mainCamera = Camera.main;
    }
    private void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Mouse0) && rb2d.velocity == Vector2.zero)
        {
            direction = mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            rb2d.AddForce(direction.normalized * speed);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            rb2d.velocity = Vector2.zero;
            transform.position = origionalPosition;
        }
    } 
}
