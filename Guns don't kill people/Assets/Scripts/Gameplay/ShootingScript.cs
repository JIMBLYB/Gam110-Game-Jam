using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField]
    private Transform barrelTip;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float speed = 1f;

    private int shots = 3;
    
    void Update()
    {
        
       
        if (Input.GetMouseButtonDown(0))
        {
            if (shots > 0)
            {
                FireBullet();
                shots = shots - 1;
            }
        }
    }
    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, barrelTip.position, barrelTip.rotation);
        firedBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * speed );
    }
}
