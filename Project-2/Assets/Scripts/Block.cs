using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour
{
    private Vector3 position;
    public string type;
    public bool swiped = false;
    public bool inSweetSpot;
    public bool passedScreen;

    // Start is called before the first frame update
    void Start()
    {
        passedScreen = GameObject.Find("Barrier").GetComponent<Collider2D>().IsTouching(gameObject.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = gameObject.transform.position;
        position.y -= Time.deltaTime * 2;
        gameObject.transform.position = position;
        passedScreen = GameObject.Find("Barrier").GetComponent<Collider2D>().IsTouching(gameObject.GetComponent<Collider2D>());
        inSweetSpot = GameObject.FindGameObjectWithTag("SweetSpot").GetComponent<Collider2D>().IsTouching(gameObject.GetComponent<Collider2D>());
        if (passedScreen){
          Debug.Log("passedScreen");
          onPassedScreen();
        }
    }

    public bool checkType(string swipe)
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

    public void SetSwiped()
    {
        swiped = true;
    }

    public void onPassedScreen()
    {
        GameObject.Find("LifeSystem").GetComponent<LifeSystem>().decreaseLives();
        GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().resetCombo();
        Destroy(this.gameObject);
    }
}
