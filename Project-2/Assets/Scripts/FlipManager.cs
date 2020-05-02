using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Nicholas Mercadante
// Script for managing when the screen should be flipped

public class FlipManager : MonoBehaviour
{

    // vars for handling phone flipping
    public float timeBetweenFlips = 10f;
    public float totalFlipTime = 10f;
    float timeLeft;
    public bool shouldBeFlipped = false;
    public bool isFlipped = false;
    public bool flipStatusMatching = true;
    // var that should track a GyroContoller in the same scene as this script
    public GyroControl gc;

    public float xOnLoad;
    public float yOnLoad;
    public float zOnLoad;

    public float zeroedX;
    public float zeroedY;
    public float zeroedZ;

    bool frameOne = true;

    // Start is called before the first frame update
    void Start()
    {
        // have timeLeft track our time until the first flip at the start of the game
        timeLeft = timeBetweenFlips;
        // find a GyroControl to attach to this script
        gc = FindObjectOfType<GyroControl>();
    }

    // Update is called once per frame
    void Update()
    {
        // if there's a GyroControl with an active gyro, proceed
        if (gc.gyroEnabled)
        {
            if (frameOne)
            {
                xOnLoad = gc.currRot.eulerAngles.x;
                yOnLoad = gc.currRot.eulerAngles.y;
                zOnLoad = gc.currRot.eulerAngles.z;
                frameOne = false;
            }

            // decrement the time left
            timeLeft -= Time.deltaTime;
            // when it hits 0, flip the flipped status
            if (timeLeft <= 0f)
            {
                // handle case of phone needing to be flipped
                if (!shouldBeFlipped)
                {
                    shouldBeFlipped = true;
                    timeLeft = totalFlipTime;
                }
                // handle case of phone needing to be UNflipped
                else
                {
                    shouldBeFlipped = false;
                    timeLeft = timeBetweenFlips;
                }
            }
            // check the gyro's rotation to set the isFlipped var
            if (gc.currRot.eulerAngles.z < 160 || gc.currRot.eulerAngles.z > 200)
                isFlipped = false;
            else
                isFlipped = true;
            // set flipStatusMatching based on isFlipped and shouldBeFlipped
            if ((shouldBeFlipped && isFlipped) || (!shouldBeFlipped && !isFlipped))
                flipStatusMatching = true;
            else
                flipStatusMatching = false;

            zeroedX = xOnLoad - gc.currRot.eulerAngles.x;
            zeroedY = yOnLoad - gc.currRot.eulerAngles.y;
            zeroedZ = zOnLoad - gc.currRot.eulerAngles.z;
        }
    }
}
