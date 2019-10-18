using System;
using UnityEngine;

[Serializable]
public struct Grid
{
    public int ID;
    public Vector2 position;
}

[Serializable]
public class MyClass : MonoBehaviour
{
    public int myData;

    private void Initialise()
    {
        myData = 5;
    }

}

public class AnotherClass : MonoBehaviour
{
    public Grid[] grids = new Grid[25];
    public MyClass[] classes;

    public Collider2D col;

    private void Start()
    {
        if (col.GetComponent<MyClass>() != null)
        {

        }
    }
}

