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

    [SerializeField]
    private int shots = 3;

    [SerializeField]
    private float coolDownTime = 0.2f;

    private float nextFireTime = 0;

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetMouseButtonDown(0))

            {
                if (shots > 0)
                {
                    FireBullet();
                    shots = shots - 1;
                    nextFireTime = Time.time + coolDownTime;
                }
            }
        }
    }
    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, barrelTip.position, barrelTip.rotation);
        firedBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right * speed);
    }
}
