using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    Vector3 lastPos = new Vector3();
    Vector3 currentPos = new Vector3();
    float magnitude;
    bool mousePressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.touchCount > 0)
        {
            currentPos = Input.GetTouch(0).position;
            Debug.Log(currentPos);
        }*/
        // Debug.Log(Input.GetMouseButton(0));
        if(Input.GetMouseButton(0))
        {
            currentPos = Input.mousePosition;
            mousePressed = true;
            // Debug.Log(currentPos);
        }

        if(mousePressed && Input.GetMouseButton(0) == false)
        {
            if (lastPos != currentPos)
            {
                // Debug.Log(currentPos - lastPos);
                Vector3 dist = currentPos - lastPos;
                magnitude = dist.magnitude;
                Debug.Log(magnitude);
                lastPos = currentPos;

            }
            else
            {
                magnitude = 0;
            }
        }
        
        // Debug.Log(Input.acceleration);

        // lastPos = currentPos;
    }

    public void OnDrag(BaseEventData eventData)
    {
        
    }

    public float getMagnitude()
    {
        return magnitude;
    }
}
