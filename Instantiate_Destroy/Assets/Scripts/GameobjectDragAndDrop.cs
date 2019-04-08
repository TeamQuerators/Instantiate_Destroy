using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameobjectDragAndDrop : MonoBehaviour
{
    public string mousecontrolled = "n";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void OnMouseDrag()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }

    
    /*void Update()
    {
        if (mousecontrolled == "y")
        {
            //mousecontrolled = "y"; //subject to change
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

    }

    void OnMouseDown()
    {
        mousecontrolled = "y";
        //gameplay.selectedSandwich = occupiedSlot;

    }*/
}
