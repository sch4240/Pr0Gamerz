using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SwipeManager))]
public class InputController : MonoBehaviour
{
    public Block block;

    // for prefabs of the split halves of the block this is attached to
    public BlockShardBreakaway blockHalf1; // for left/top pieces
    public BlockShardBreakaway blockHalf2; // for right/bottom pieces

    public string direction;

    void Start()
    {
        SwipeManager swipeManager = gameObject.GetComponent<SwipeManager>();
        swipeManager.onSwipe += HandleSwipe;
        swipeManager.onLongPress += HandleLongPress;
        block = gameObject.GetComponent<Block>();
    }

    void HandleSwipe(SwipeAction swipeAction)
    {
        // if a block has been swiped through and is in the sweetspot, check the direction to see if it needs to be destroyed
        if (gameObject.GetComponent<Block>().swiped)
        {
            // if its in the sweetspot & has been flipped to the correct orientation, proceed
            if (gameObject.GetComponent<Block>().inSweetSpot && FindObjectOfType<FlipManager>().flipStatusMatching)
            {
                if (swipeAction.direction == SwipeDirection.Up)
                {
                    direction = "up";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.UpRight)
                {
                    direction = "upright";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();    
                        }
                }
                else if (swipeAction.direction == SwipeDirection.Right)
                {
                    direction = "right";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.DownRight)
                {
                    direction = "downright";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.Down)
                {
                    direction = "down";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.DownLeft)
                {
                    direction = "downleft";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.Left)
                {
                    direction = "left";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else if (swipeAction.direction == SwipeDirection.UpLeft)
                {
                    direction = "upleft";
                    if (block != null)
                        if (block.checkType(direction))
                        {
                            Instantiate(blockHalf1, new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1, 0), Quaternion.identity);
                            Instantiate(blockHalf2, new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y - 1, 0), Quaternion.identity);
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else
                {
                    block.GetComponent<Block>().swiped = false;
                }
            }
            else // handle the case of the block being swiped outside the sweetspot or the phone being in an incorrect orientation
            {
                GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().resetCombo();
                Destroy(gameObject);
            }
        }
    }

    void HandleLongPress(SwipeAction swipeAction)
    {
        //Debug.LogFormat("HandleLongPress: {0}", swipeAction);
    }
}
