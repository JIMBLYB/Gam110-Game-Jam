using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public Sprite hoverSprite;
    public Sprite defaultSprite;
    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter()
    {
        sr.sprite = hoverSprite;
    }
    

    private void OnMouseExit()
    {
        sr.sprite = defaultSprite;
    }


}
