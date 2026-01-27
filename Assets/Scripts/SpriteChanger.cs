using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color colourPick;
    //array variable
    //public Sprite[] Barrels;
    //array list variable
    public List<Sprite> Barrels;
    //between whole numbers
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        //below is a boolean without the == true
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("Try to change the sprite please");
            //PickARandomColour();
            if (Barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

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

        if (Mouse.current.leftButton.wasPressedThisFrame == true && Barrels.Count >0)
        {
            Barrels.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();        
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;

        //pick a random number
        //range is length of the array that is dynamic to the inspector settings
        //specific to arrays
        //randomNumber = Random.Range(0, Barrels.Length);
        //lists use count instead of length
        randomNumber = Random.Range(0, Barrels.Count);

        //use that number to choose a sprite        
        //this way is too long
        //if(randomNumber == 0)
        //{
        //    spriteRenderer.sprite = Barrel0;
        //}
        //else if(randomNumber == 1)
        //{
        //    spriteRenderer.sprite = Barrel1;
        //}
        //else if( randomNumber == 2)
        //{
        //    spriteRenderer.sprite = Barrel2;
        //}
        //assign that sprite to the sprite renderer
        spriteRenderer.sprite = Barrels[randomNumber];
    }
}
