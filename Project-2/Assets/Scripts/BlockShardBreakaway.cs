using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShardBreakaway : MonoBehaviour
{
    // variables for adjusting the forces applied to the shard when spawned and the y position at which it should destroy itself
    public float minForce = -3; // NEGATIVE VALUE ONLY
    public float maxForce = 3; // POSITIVE VALUE ONLY
    public float heightToDestroy = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = gameObject.GetComponent<Rigidbody2D>();
        switch (gameObject.tag)
        {
            case "LeftShard":
                rb2d.AddForce(new Vector2(-maxForce, Random.Range(minForce, maxForce)));
                break;
            case "TopLeftShard":
                rb2d.AddForce(new Vector2(Random.Range(-maxForce, 0), Random.Range(0, maxForce)));
                break;
            case "TopShard":
                rb2d.AddForce(new Vector2(Random.Range(minForce, maxForce), maxForce));
                break;
            case "TopRightShard":
                rb2d.AddForce(new Vector2(Random.Range(0, maxForce), Random.Range(0, maxForce)));
                break;
            case "RightShard":
                rb2d.AddForce(new Vector2(maxForce, Random.Range(minForce, maxForce)));
                break;
            case "BottomRightShard":
                rb2d.AddForce(new Vector2(Random.Range(0, maxForce), Random.Range(-maxForce, 0)));
                break;
            case "BottomShard":
                rb2d.AddForce(new Vector2(Random.Range(minForce, maxForce), -maxForce));
                break;
            case "BottomLeftShard":
                rb2d.AddForce(new Vector2(Random.Range(-maxForce, 0), Random.Range(-maxForce, 0)));
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= heightToDestroy)
            Destroy(gameObject);
    }
}
