using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollow : MonoBehaviour
{
    public bool FollowOnXOnly = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reference FollowMe script from class
        //system reads current position of mouse in world space
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //the mouse position affects the transform coordinates of the game object
        //though here I want to be able to choose whether the game object follows X & Y or just X axis
        //use a bool to check preference, and if checked to true, transform only the x coordinates via mouse
        //if false, transform both X & Y coordinates

        if (FollowOnXOnly == true) 
        {
            transform.position = new Vector2(mousePos.x, transform.position.y);
        } else if(FollowOnXOnly == false)
        {
            transform.position = mousePos;
        }
        

    }
}
