using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoScript : MonoBehaviour
{
    [SerializeField]
    private Sprite BulletIconUsed;
    int counter = 0;
    [SerializeField]
    private GameObject ammo1;
    [SerializeField]
    private GameObject ammo2;

    private void Update()
    {
        if (counter == 0) 
        {
            if (Input.GetMouseButtonDown(0))
            {
            this.gameObject.GetComponent<Image>().sprite = BulletIconUsed;
            counter++;

            }
        }

        if (counter == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ammo1.GetComponent<Image>().sprite = BulletIconUsed;
                counter++;
            }
        }

        if (counter == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ammo2.GetComponent<Image>().sprite = BulletIconUsed;
            }
        }
    }
    
}
