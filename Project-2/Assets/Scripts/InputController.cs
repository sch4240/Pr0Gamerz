using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SwipeManager))]
public class InputController : MonoBehaviour
{
    public Block block;

    public string direction;

    void Start()
    {
        SwipeManager swipeManager = gameObject.GetComponent<SwipeManager>();
        swipeManager.onSwipe += HandleSwipe;
        swipeManager.onLongPress += HandleLongPress;
    }

    void HandleSwipe(SwipeAction swipeAction)
    {
        // if a block has been swiped through and is in the sweetspot, check the direction to see if it needs to be destroyed
        if (gameObject.GetComponent<Block>().swiped)
        {
            // if its in the sweetspot, proceed
            if (gameObject.GetComponent<Block>().inSweetSpot)
            {
                if (swipeAction.direction == SwipeDirection.Up)
                {
                    direction = "up";
                    if (block != null)
                        if (block.checkType(direction))
                        {
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
                            Destroy(gameObject);
                            GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().increaseScore();
                        }
                }
                else
                {
                    block.GetComponent<Block>().swiped = false;
                }
            }
            else // handle the case of the block being swiped outside the sweetspot
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
