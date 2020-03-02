using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerExitHandler
{
    private Vector3 position;
    public string type;
    public bool swiped = false;
    public bool passedScreen;

    // Start is called before the first frame update
    void Start()
    {
        passedScreen = GameObject.Find("Barrier").GetComponent<Collider2D>().IsTouching(gameObject.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        position.y -= Time.deltaTime * 2;
        this.transform.position = position;
        passedScreen = GameObject.Find("Barrier").GetComponent<Collider2D>().IsTouching(gameObject.GetComponent<Collider2D>());
        Debug.Log("passedScreen: " + passedScreen);
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
      if(passedScreen){
        Destroy(this.gameObject);
        GameObject.Find("LifeSystem").GetComponent<LifeSystem>().decreaseLives();
        GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().resetCombo();
      }
    }
}
