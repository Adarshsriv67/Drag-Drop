using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public List<Transform> DropPoint;
    public List<Drag> dragObject;
    public GameObject gameObject;
    public float dragRange = 0.5f;
    private Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        foreach (Drag drag in dragObject)
        {
            drag.dragEndedCallback = OnDragEnded;
        }
    }
    private void OnDragEnded(Drag drag)
    {
        float closestDistance = -1;
        Transform closestDropPoint = null;
        foreach(Transform DropPoint in DropPoint)
        {
            float currentDistance = Vector2.Distance(drag.transform.localPosition, DropPoint.localPosition);
            if(closestDropPoint==null || currentDistance<closestDistance)
            {
                closestDropPoint = DropPoint;
                closestDistance = currentDistance;
            }
           
        }
        if(closestDropPoint != null && closestDistance <= dragRange)
        {
            drag.transform.localPosition = closestDropPoint.localPosition;
        }
        else if(closestDistance>dragRange)
        {
            gameObject.transform.position = originalPos;
        }
    }
}
