using UnityEngine;
using UnityEngine.UI;

public class globalSwitch : MonoBehaviour
{
    SpriteRenderer inv;
    public Image duckImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inv = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        inv.color = Random.ColorHSV();
        duckImage.color = inv.color;
    }
}
