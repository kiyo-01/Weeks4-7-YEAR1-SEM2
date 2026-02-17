using UnityEngine;

public class SoupColor : MonoBehaviour
{
    //originally was only meant to control color, but ended up controlling much more
    //SoupControl would be a much more fitting name, and is used for every reference in the future
    public FabMaker fabMaker;
    private SpriteRenderer soup;

    //public variables for other scripts to access and change other things
    public bool healP = false;
    public bool manaP = false;
    public bool loveP = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //access colors
        soup = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //change soup color + turn on/off variables depending on the amount of eyes/mushrooms you put in
        if (fabMaker.eyeCount >= 5)
        {
                soup.color = Color.blue;
                manaP = true;
        }
        if (fabMaker.mushCount >= 5)
        {
                soup.color = Color.red;
                healP = true;
        }
        if (fabMaker.mushCount >= 5 && fabMaker.eyeCount >= 5)
        {
                soup.color = Color.magenta;
                loveP = true;
                manaP = false;
                healP = false;
            
        }
        else if (fabMaker.mushCount < 5 && fabMaker.eyeCount < 5)
        {
            soup.color = Color.white;
        }
    }
}
