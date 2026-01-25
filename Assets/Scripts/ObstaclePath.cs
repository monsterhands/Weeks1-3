using System.Security.Cryptography;
using UnityEngine;

public class ObstaclePath : MonoBehaviour
{
    //Set public float variables for speeds, a minimum and a maximum for a numerical range
    public float minSpeed;
    public float maxSpeed;
    //Set a float variable (t) for measuring time and path of the lerp
    float t;
    //Set transform variables for the game objects that affect the path of the raindrop’s lerp 
    //including an obstacle (the umbrella)
    public Transform start;
    public Transform end;
    public Transform obstacle;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        //Introduce a random speed variable in a range using the min/max speed variables
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        //Use deltaTime to affect the lerp’s timing multiplied by the random speed from the range
        t += Time.deltaTime * randomSpeed;

        //Detect overlap using distance between this object’s current position and the
        //position of the obstacle
        float overlap = Vector2.Distance(transform.position, obstacle.position);

        //If the lerp reaches its final value at 1 OR is within a distance indicated,
        //reset the lerp to zero
        if (t > 1 || overlap < 2)
        {
            t = 0;
        }
        //Finally, the transform is sent on a Vector2 lerp from the position of the start object
        //to end object by (t)
        transform.position = Vector2.Lerp(start.position, end.position, t);
            
    }

}
