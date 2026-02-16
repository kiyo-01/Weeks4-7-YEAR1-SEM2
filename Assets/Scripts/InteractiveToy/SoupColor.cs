using UnityEngine;

public class SoupColor : MonoBehaviour
{
    public FabMaker fabMaker;
    private SpriteRenderer soup;

    private float delayTime = 0;
    public float waitTime = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soup = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fabMaker.eyeCount >= 5)
        {
            delayTime += Time.deltaTime;

            if (delayTime >= waitTime)
            {
                soup.color = Color.blue;

                delayTime = 0;
            }
        }
        if (fabMaker.mushCount >= 5)
        {
            soup.color = Color.red;

            delayTime = 0;
        }
        if (fabMaker.mushCount >= 5 && fabMaker.eyeCount >= 5)
        {
            soup.color = Color.magenta;
        }
    }
}
