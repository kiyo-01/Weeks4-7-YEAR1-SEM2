using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class pirateMaybe : MonoBehaviour
{
    public SpriteRenderer pirate;
    public Boolean piratePerhaps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (pirate.bounds.Contains(mousePos) == true)
        {
            piratePerhaps = true;
        }
        else
        {
            piratePerhaps = false;
        }
    }
}
