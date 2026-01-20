using UnityEngine;

public class TimedColour : MonoBehaviour
{
    //Make a script with public SpriteRenderer variable. In the inspector, drag in a reference to a SpriteRenderer.
    //Write a timer that makes the sprite change to a random colour(use Random.ColorHSV()) every second.
    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //need to change this with variable including time to fix
        if (Time.deltaTime > 0)
        {
            PickARandomColour();
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
