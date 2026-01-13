using Unity.VisualScripting;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public AnimationCurve curve;
    public float t;
    float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position); 

        if (t < 0 || t > 1)
        {
            speed = speed * -1;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
