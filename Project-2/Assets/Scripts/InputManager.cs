using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    public GameObject dot;
        // Start is called before the first frame update
    void Start()
    {

    }

        // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(dot, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }

    public void OnDrag(BaseEventData eventData)
    {
        
    }
}
