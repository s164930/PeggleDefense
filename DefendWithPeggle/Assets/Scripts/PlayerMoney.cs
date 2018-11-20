using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour {
    public static int Money;
    public int startMoney = 1000;

    private void Start()
    {
        Money = startMoney;
    }

}
