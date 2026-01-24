using System.Security.Cryptography;
using UnityEngine;

public class PerspectiveMotion : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private float timer;
    public float speed;
    public float wait;
    public AnimationCurve curveMotion;
    public AnimationCurve curveSize;
    public float size;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * speed;

        if (timer > wait)
        {
            timer = timer - wait;
        } 

        transform.position = Vector2.Lerp(start.position, end.position, curveMotion.Evaluate(timer));
        transform.localScale = (Vector3.one * size) * curveSize.Evaluate(timer);
    }
}
