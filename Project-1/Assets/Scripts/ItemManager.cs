using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // bools for items that the destroyable objs will check against during gameplay
    public bool extraDamage;
    public bool extraMoney;
    public bool extraTime;

    public void changeExtraDamage(){
      extraDamage = !extraDamage;
    }

    public void changeExtraMoney(){
      extraMoney = !extraMoney;
    }

    public void changeExtraTime(){
      extraTime = !extraTime;
    }

    // Start is called before the first frame update
    void Awake()
    {
      DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
