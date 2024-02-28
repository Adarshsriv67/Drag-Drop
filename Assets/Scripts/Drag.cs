using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public delegate void DragEndedDelegate(Drag drag);
    public DragEndedDelegate dragEndedCallback;
    public bool isDragging;
    private Vector3 mouseDragStartposition;
    private Vector3 objectDragStartPosition;
    
    public void OnMouseDown()
    {
        isDragging = true;
        mouseDragStartposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectDragStartPosition = transform.localPosition;
    }
    private void OnMouseDrag()
    {
        if(isDragging)
        {
            transform.localPosition = objectDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartposition);
        }
    }

    public void OnMouseUp()
    {
        isDragging = false;
        dragEndedCallback(this);     
    }
}
