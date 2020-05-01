using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationDebugUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // if(FindObjectOfType<FlipManager>().isFlipped)
      //     gameObject.GetComponent<Text>().text = "Flipped";
      // else
      //     gameObject.GetComponent<Text>().text = "Standard";

      gameObject.GetComponent<Text>().text = "" + FindObjectOfType<FlipManager>().gc.currRot.eulerAngles.z;
    }
}
