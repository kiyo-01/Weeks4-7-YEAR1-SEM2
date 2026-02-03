using TMPro;
using UnityEngine;

public class description : MonoBehaviour
{
    public TextMeshProUGUI desc;
    public duckMaybe duckMaybe;
    public pirateMaybe pirateMaybe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        duckMaybe = duckMaybe.GetComponent<duckMaybe>();
        pirateMaybe = pirateMaybe.GetComponent<pirateMaybe>();
    }

    // Update is called once per frame
    void Update()
    {
        if (duckMaybe.duckPerhaps == true)
        {
            desc.text = "A yellow rubber duck.";
        }
        else if (pirateMaybe.piratePerhaps == true)
        {
            desc.text = "A rowdy seafarer.";
        }
        else
        {
            desc.text = "description";
        }
    }
}
