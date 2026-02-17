using UnityEngine;
using UnityEngine.UI;

public class EyeTimer : MonoBehaviour
{
    public float timerV = 0;
    public float timerMV = 10;
    public GameObject eye;
    public float spinSpeed = 300;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //death timer: the way the cauldron is set up, this is the best way for the item to "fall" into the soup
        timerV += Time.deltaTime;

        //spin during fall to look nice
        Vector3 spin = transform.eulerAngles;
        spin.z += spinSpeed * Time.deltaTime;
        transform.eulerAngles = spin;

        //fall/gravity logic
        float fallY = transform.position.y - 5 * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, fallY, -1f);

        //destroys prefab once it "dies"
        if (timerV > timerMV)
        {
            timerV = 0;
            Destroy(eye);
        }

    }
}
