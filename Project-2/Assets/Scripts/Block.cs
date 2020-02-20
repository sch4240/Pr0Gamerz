using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Vector3 position;

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        position.y -= Time.deltaTime * 2;
        this.transform.position = position;
    }

    public void onBlockDestroyed(){
        GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
    }
}
