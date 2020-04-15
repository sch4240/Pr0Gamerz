﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public List<Block> blocks;

    float beatTimer = 2.0f;

    public float bpm;

    void Start()
    {
        beatTimer = (240/bpm);
    }

    // Update is called once per frame
    void Update()
    {
        beatTimer -= Time.deltaTime;

        if(beatTimer < 0)
        {
            int index = Random.Range(0, blocks.Count);
            Vector2 blockPos = new Vector2(Random.Range(-215, 213), 354);
            Block block = Instantiate(blocks[index], blockPos, Quaternion.identity);
            block.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            beatTimer = (240/bpm);
        }
    }
}
