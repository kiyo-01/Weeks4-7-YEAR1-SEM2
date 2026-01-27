using UnityEngine;
using NUnit.Framework;
using UnityEngine.InputSystem;


public class BirdKiller : MonoBehaviour
{
    public SpriteRenderer bird;
    private GameObject postFab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if(bird.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Destroy(bird);
        }
    }

}
