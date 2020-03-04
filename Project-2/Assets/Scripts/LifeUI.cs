using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour
{
  public int livesToDisplay;

  // Update is called once per frame
  void Update()
  {
      livesToDisplay = GameObject.Find("LifeSystem").GetComponent<LifeSystem>().getLives();
      gameObject.GetComponent<Text>().text = "Lives: " + livesToDisplay;
  }
}
