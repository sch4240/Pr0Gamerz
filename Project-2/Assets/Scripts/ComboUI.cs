using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboUI : MonoBehaviour
{
    public int comboToDisplay;

    // Update is called once per frame
    void Update()
    {
        comboToDisplay = GameObject.Find("ScoringSystem").GetComponent<ScoringSystem>().getCombo();
        gameObject.GetComponent<Text>().text = "Combo: " + comboToDisplay;
    }
}
