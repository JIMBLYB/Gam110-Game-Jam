﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            Destroy(this.gameObject);
        }
    }
}