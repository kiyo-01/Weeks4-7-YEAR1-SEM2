using UnityEngine;
using UnityEngine.UI;

public class EyeTimer : MonoBehaviour
{
    public float timerV = 0;
    public float timerMV = 10;
    public GameObject eyeMer;
    public GameObject mushMer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        timerV += Time.deltaTime;

        if (timerV > timerMV)
        {
            timerV = 0;
            Destroy(eyeMer);
        }

    }
}
