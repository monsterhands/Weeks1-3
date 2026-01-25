using System.Security.Cryptography;
using UnityEngine;

public class PerspectiveMotion : MonoBehaviour
{
    //set public float variables for the game objects that affect the path of this object's lerp 
    public Transform start;
    public Transform end;
    //set a float variable for measuring time duration
    private float timer;
    //set a float variable for affecting speed of movement
    public float speed;
    //set a float variable for measuring the wait time between the end and resumption of the lerp function
    public float wait;
    //set animation curves for affecting the motion and scale of game object
    public AnimationCurve curveMotion;
    public AnimationCurve curveSize;
    //set float variable for the size of the game object
    public float size;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set timer to zero at start of play
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //timer needs to update by deltaTime and be changed by speed set in inspector
        timer += Time.deltaTime * speed;

        //if the timer reaches a value greater than the wait time
        //one update plus a value set in inspector
        if (timer > wait)
        {
            //timer is reset to remove the wait period that has just occurred
            timer = timer - wait;
        } 

        //the position of the affected game object is linearly interpolated from a chosen start game object position
        //to an end game object position with animation curve motion along the value of the timer,
        //0-1 with speed factored in
        transform.position = Vector2.Lerp(start.position, end.position, curveMotion.Evaluate(timer));
        //conversely, this animation curve changes the scale as it evaluates the value of the timer
        //multiplying a vector3 of scale by the size set in the inspector to affect X, Y
        transform.localScale = (Vector2.one * size) * curveSize.Evaluate(timer);
    }
}
