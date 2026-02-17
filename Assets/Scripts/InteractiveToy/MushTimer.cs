using UnityEngine;

public class MushTimer : MonoBehaviour
{
    public float timerV = 0;
    public float timerMV = 3;
    public GameObject mush;
    public float speed = 200;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //same logic on eyeTimer; reference it for comments/explanation
        timerV += Time.deltaTime;

        Vector3 spin = transform.eulerAngles;
        spin.z += speed * Time.deltaTime;
        transform.eulerAngles = spin;

        float fallY = transform.position.y - 5 * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, fallY, -1f);

        if (timerV >= timerMV)
        {
            timerV = 0;
            Destroy(mush);
        }
    }
}
