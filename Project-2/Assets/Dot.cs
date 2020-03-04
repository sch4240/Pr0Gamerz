using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dot : MonoBehaviour
{
    float totalTime = 0.5f;
    float timeLeft = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 255 * (timeLeft / totalTime));
        }
    }
}
