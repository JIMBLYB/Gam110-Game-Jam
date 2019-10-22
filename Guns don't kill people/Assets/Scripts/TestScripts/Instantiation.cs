using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;

    void Start()
    {
        Instantiate(myPrefab, new Vector2(-3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
