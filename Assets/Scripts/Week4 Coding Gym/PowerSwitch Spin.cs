using UnityEngine;

public class PowerSwitchSpin : MonoBehaviour
{
    public float speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 powerSpin = transform.eulerAngles;
        powerSpin.z += speed * Time.deltaTime;
        transform.eulerAngles = powerSpin;
    }

    public void StartSpin()
    {
        speed = 100;
    }

    public void StopSpin()
    {
        speed = 0;
    }

}
