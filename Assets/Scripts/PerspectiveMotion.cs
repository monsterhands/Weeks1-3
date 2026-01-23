using System.Security.Cryptography;
using UnityEngine;

public class PerspectiveMotion : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private float t;
    public float speed;
    public AnimationCurve curveMotion;
    public AnimationCurve curveSize;
    public float size;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;

        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curveMotion.Evaluate(t));
        transform.localScale = (Vector3.one * size) * curveSize.Evaluate(t);
    }
}
