using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CarDestroy : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }   
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        
            anim.Play("Car_Explosion");
        
    }
}
