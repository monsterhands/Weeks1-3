using System.Security.Cryptography;
using UnityEngine;

public class ObstaclePath : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    float t;
    public Transform start;
    public Transform end;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        t += Time.deltaTime * randomSpeed;

        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);

    }

}
