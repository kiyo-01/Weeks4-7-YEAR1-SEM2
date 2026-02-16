using UnityEngine;

public class FabMaker : MonoBehaviour
{
    public GameObject bigEye;
    public GameObject bigMush;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEye()
    {
        Vector2 vector2 = transform.position;
        transform.position = new Vector3(0, 5);

        Instantiate(bigEye, transform.position, transform.rotation);
    }

    public void SpawnMush()
    {
        Vector2 vector2 = transform.position;
        transform.position = new Vector3(0, 5);
        
        Instantiate(bigMush, transform.position, transform.rotation);
    }
}
