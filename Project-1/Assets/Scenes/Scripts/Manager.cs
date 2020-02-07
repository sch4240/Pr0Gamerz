using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Manager : MonoBehaviour
{
    // gameobject to spawn in
    public List<GameObject> objects;
    public int numDestroyed;
    private float spawnTimer;
    private float spawnTime;
    public int highScore;

    // public List<GameObject> gameObjs;

    // Start is called before the first frame update
    void Start()
    {
        numDestroyed = 0;
        spawnTime = 3.0f;
        spawnTimer = spawnTime;
        // gameObjs = new List<GameObject>();

        int objNum = Random.Range(0, 23);
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-4.0f, 4.0f);
        Instantiate(objects[objNum], new Vector2(x, y), Quaternion.identity);
        spawnTimer = spawnTime;

        LoadScore();
    }

    // Update is called once per frame
    void Update()
    {
        SaveHighScore(0);
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            int objNum = Random.Range(0, 22);
            float x = Random.Range(-10.0f, 10.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Instantiate(objects[objNum], new Vector2(x,y), Quaternion.identity);
            spawnTimer = spawnTime;
            
        }
    }

    public void SaveHighScore(int highScore)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/score.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        int savedHighScore = highScore;

        formatter.Serialize(stream, savedHighScore);
        stream.Close();
    }

    public int LoadScore()
    {
        string path = Application.persistentDataPath + "/score.txt";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            highScore = (int)formatter.Deserialize(stream);

            return highScore;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
        }
        return 0;
    }
}
