using UnityEngine;

public class FabMaker : MonoBehaviour
{
    //fab spawner and also tracks eye and mushroom numbers
    public GameObject bigEye;
    public GameObject bigMush;
    public int eyeCount;
    public int mushCount;

    public SoupColor soupControl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn eye and mush at a set Y level, with a slightly random X value (so it looks more satisfying when spammed)
    public void SpawnEye()
    {
        Vector2 vector2 = transform.position;
        transform.position = new Vector3(Random.Range(-1f, 1f), 5);

        Instantiate(bigEye, transform.position, transform.rotation);

        eyeCount += 1;
    }

    public void SpawnMush()
    {
        Vector2 vector2 = transform.position;
        transform.position = new Vector3(Random.Range(-1f, 1f), 5);
        
        Instantiate(bigMush, transform.position, transform.rotation);

        mushCount += 1;
    }

    public void RestartPotion()
    {
        //reset variables and counts to default
        mushCount = 0;
        eyeCount = 0;
        soupControl.healP = false;
        soupControl.manaP = false;
        soupControl.loveP = false; 
    }


}
