using UnityEngine;
using UnityEngine.UI;

public class FireLevel : MonoBehaviour
{
    public Slider heat;
    public GameObject firePNG;
    private Transform fireSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this line feels slightly roundabout but it wasn't working in its original way, not sure why
        fireSize = firePNG.GetComponent<Transform>();
        heat.maxValue = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireHeight(float sliderValue)
    {
        //fire's scale.y changes while the others are set in stone
        fireSize.localScale = new Vector3(0.5f, sliderValue, 0);
    }
}
