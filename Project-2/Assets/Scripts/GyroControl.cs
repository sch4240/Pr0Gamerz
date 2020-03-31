using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Nick Mercadante
// Script for instantiating and keeping track of a gyroscope

public class GyroControl : MonoBehaviour
{

    public bool gyroEnabled;
    Gyroscope gyro;
    public Quaternion currRot; // Quaternion to access when assessing phone rotation during gameplay

    // Start is called before the first frame update
    void Start()
    {
        // set the gyro status by checking for one
        gyroEnabled = EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        // if there's a gyro, update the current rotation var
        if (gyroEnabled)
        {
            currRot = gyro.attitude;
        }
    }

    bool EnableGyro() {
        // check if a gyroscope is present in the system that's running this game
        if (SystemInfo.supportsGyroscope)
        {
            // attach the gyro to our tracked var and enable it, then return true
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        // if no gyro system found, return false
        return false;
    }
}
