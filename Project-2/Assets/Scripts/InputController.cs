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
        SwipeManager swipeManager = GetComponent<SwipeManager>();
        swipeManager.onSwipe += HandleSwipe;
        swipeManager.onLongPress += HandleLongPress;
    }

    void HandleSwipe(SwipeAction swipeAction)
    {
        // if a block has been swiped through, check the direction to see if it needs to be destroyed
        if (gameObject.GetComponent<Block>().swiped)
        {
            //Debug.LogFormat("HandleSwipe: {0}", swipeAction);
            if (swipeAction.direction == SwipeDirection.Up)
            {
                direction = "up";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);

                    }
            }
            else if (swipeAction.direction == SwipeDirection.UpRight)
            {
                direction = "upright";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.Right)
            {
                direction = "right";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.DownRight)
            {
                direction = "downright";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.Down)
            {
                direction = "down";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.DownLeft)
            {
                direction = "downleft";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.Left)
            {
                direction = "left";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else if (swipeAction.direction == SwipeDirection.UpLeft)
            {
                direction = "upleft";
                if (block != null)
                    if (block.checkType(direction))
                    {
                        Destroy(gameObject);
                    }
            }
            else
            {
                block.GetComponent<Block>().swiped = false;
            }
        }
    }

    void HandleLongPress(SwipeAction swipeAction)
    {
        //Debug.LogFormat("HandleLongPress: {0}", swipeAction);
    }
}