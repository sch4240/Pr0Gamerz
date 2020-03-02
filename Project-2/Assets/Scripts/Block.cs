using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerExitHandler
{
    private Vector3 position;
    public string type;
    public bool swiped = false;
    public bool onScreen;

    // Start is called before the first frame update
    void Start()
    {
        //onScreen = GetComponent<MeshRenderer>().isVisible;
        //Debug.Log("isVisible: " + GetComponent<Renderer>().isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        position.y -= Time.deltaTime * 2;
        this.transform.position = position;
        //onScreen = GetComponent<Renderer>().isVisible;
        //Debug.Log("Position: " + position.y);
        //Debug.Log("transform: " + this.transform.position.y);
    }

    public bool checkType(string swipe)
    {
        if(position.y < 5)
        {
            if (swipe == type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;

    }

    public void SetSwiped()
    {
        swiped = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        swiped = true;
    }

    public void OnScreenExit(){
      if(!onScreen && this.transform.position.y < 0){
        Destroy(this.gameObject);
        GameObject.Find("LifeSystem").GetComponent<LifeSystem>().decreaseLives();
        GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().resetCombo();
      }
    }
}
