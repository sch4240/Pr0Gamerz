using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // gameobject to spawn in
    public GameObject targetObj;
    public int numDestroyed;
    private int dest;

    // Start is called before the first frame update
    void Start()
    {
        numDestroyed = 0;
        GameObject target = Instantiate(targetObj, Vector2.zero, Quaternion.identity);
        dest = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(dest < numDestroyed)
        {
            Instantiate(targetObj, Vector2.zero, Quaternion.identity);
        }
        dest = numDestroyed;
    }
}
