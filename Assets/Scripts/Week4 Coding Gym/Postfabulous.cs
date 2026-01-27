using UnityEngine;

public class Postfabulous : MonoBehaviour
{
    public GameObject postFab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawningtonPalace()
    {
        Vector2 vector2 = transform.position;

        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5));

        Instantiate(postFab, transform.position, transform.rotation);
    }
}
