using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // gameobject to spawn in
    public List<GameObject> objects;
    public int numDestroyed;
    private float spawnTimer;
    private float spawnTime;

    public GameObject[] objList;

    // Start is called before the first frame update
    void Start()
    {
        numDestroyed = 0;
        spawnTime = 1.0f;
        spawnTimer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            int objNum = Random.Range(0, 23);
            float x = Random.Range(-10.0f, 10.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Instantiate(objects[objNum], new Vector2(x,y), Quaternion.identity);
            spawnTimer = spawnTime;
        }
    }
}
