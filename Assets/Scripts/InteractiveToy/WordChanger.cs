using TMPro;
using UnityEngine;

public class WordChanger : MonoBehaviour
{
    public TextMeshProUGUI potionText;
    public SoupColor soupControl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //access the text box
        potionText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //check variables from soupcolor and make the text depending on that
        if (soupControl.healP == true)
        {
            potionText.text = "You made a healing potion!";
        }
        if (soupControl.manaP == true)
        {
            potionText.text = "You made a mana potion!";
        }
        if (soupControl.loveP == true)
        {
            potionText.text = "Huh... you made a love potion, weirdo.";
        }
        else if (soupControl.loveP == false && soupControl.healP == false && soupControl.manaP == false) 
        {
            potionText.text = "Let's make a potion!";
        }
    }
}
