using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System;

public class duckMaybe : MonoBehaviour
{
    public SpriteRenderer duck;
    public Boolean duckPerhaps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (duck.bounds.Contains(mousePos) == true)
        {
            duckPerhaps = true;
        }
        else
        {
            duckPerhaps = false;
        }
    }

    
}
