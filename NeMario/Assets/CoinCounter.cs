using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {
    public Text textField;

    private int coins;
    public int Coins {
        get {
            return coins;
        }
        set {
            textField.text = value.ToString();

            coins = value;
        }
    }
}
