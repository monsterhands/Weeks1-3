using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color colourPick;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //below is a boolean without the == true
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    PickARandomColour();
        //}

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape?
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: set the colour with colourPick variable
            spriteRenderer.color = colourPick;
        }
        else
        {
            //N: set the colour to white
            spriteRenderer.color = Color.white;
        }

        //N: set the colour to white
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();        
    }
}
