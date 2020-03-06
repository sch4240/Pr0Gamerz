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
        if(Input.GetMouseButton(0))
        {
            GameObject newDot = Instantiate(dot,  new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
            newDot.transform.SetParent(GameObject.Find("MainScreenCanvas").transform);
            // Vector3 mousetoworld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // newDot.GetComponent<RectTransform>().localPosition = new Vector3(mousetoworld.x, mousetoworld.y, 0);
            newDot.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 1);

            Canvas canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
            Vector2 newPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out newPos);
            newDot.transform.position = canvas.transform.TransformPoint(newPos);
        }
    }

    public void OnDrag(BaseEventData eventData)
    {
    }
}
