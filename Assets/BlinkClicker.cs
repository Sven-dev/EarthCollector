using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkClicker : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SpriteRenderer;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        print("clicked");
        if (SpriteRenderer.color == Color.black)
        {
            print("color is black");
            SpriteRenderer.color = Color.white;
        }
        else if (SpriteRenderer.color == Color.white)
        {
            print("color is white");
            SpriteRenderer.color = Color.black;
        }
    }
}