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
        //Debug.LogFormat("HandleSwipe: {0}", swipeAction);
        if (swipeAction.direction == SwipeDirection.Up)
        {
            direction = "up";
            // move up
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.UpRight)
        {
            direction = "upright";
            // move right
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.Right)
        {
            direction = "right";
            // move down
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.DownRight)
        {
            direction = "downright";
            // move left
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.Down)
        {
            direction = "down";
            // move left
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.DownLeft)
        {
            direction = "downleft";
            // move left
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.Left)
        {
            direction = "left";
            // move left
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
        else if (swipeAction.direction == SwipeDirection.UpRight)
        {
            direction = "upright";
            // move left
            if (block != null)
                if (block.checkType(direction))
                {
                    Destroy(gameObject);
                }
        }
    }

    void HandleLongPress(SwipeAction swipeAction)
    {
        //Debug.LogFormat("HandleLongPress: {0}", swipeAction);
    }
}