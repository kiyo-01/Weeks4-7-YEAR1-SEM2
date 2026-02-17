using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isHit = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;

    public UnityEvent<float> OnRandomNumber;

    void Start()
    {

    }

    void Update()
    {
        //this code only checks if youre in the hitbox this frame, rather than constantly checking
        //is the player inside the hazard sprite?
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if(isHit == true)
            {
                //we're still in the hazard
            }
            else
            {
                //just entered the hazard! do something
                //Y: player has tripped the sensor
                isHit = true;
                Debug.Log("Entered the hazard!");
                OnEnterHazard.Invoke();
            }    
        }
        else
        {
            if (isHit == true)
            {
                //we just left the hazard
                //N: player has not tripped the sensor
                isHit = false;
                Debug.Log("Exited the hazard!");
                OnExitHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
            else
            {
                //we're still not in the hazard
            }
            
        }

    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
