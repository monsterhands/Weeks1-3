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
    //set a animation curves for affecting the motion and scale of game object
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
        //tbd
        timer += Time.deltaTime * speed;

        if (timer > wait)
        {
            timer = timer - wait;
        } 

        transform.position = Vector2.Lerp(start.position, end.position, curveMotion.Evaluate(timer));
        transform.localScale = (Vector3.one * size) * curveSize.Evaluate(timer);
    }
}
