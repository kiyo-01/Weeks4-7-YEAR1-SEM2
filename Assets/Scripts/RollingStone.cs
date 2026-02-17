using UnityEngine;
using UnityEngine.Events;

public class RollingStone : MonoBehaviour
{
    public SpriteRenderer stone;
    public SpriteRenderer lara;
    public GameObject stonesy;
    public float speed = 0.025f;
    public bool isRolling = false;
    Vector2 stonePos;

    public UnityEvent deathByStone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stone = GetComponent<SpriteRenderer>();
        lara = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRolling)
        {
            speed = 0.025f;

            stonePos = transform.position;

            stonePos.x -= speed;

            transform.position = stonePos;
        }
        else
        {
            speed = 0;
        }

        if (stonePos.x < -10)
        {
            Destroy(stonesy);
        }

        if (lara.bounds.Contains(stonePos))
        {
            deathByStone.Invoke();
        }

    }

    public void StoneRolling()
    {
        isRolling = true;
    }
}
