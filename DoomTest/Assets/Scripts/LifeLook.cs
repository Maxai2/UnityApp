using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeLook : MonoBehaviour {

    public Text life;

    private int lifeProp;
    public int LifeProp {
        get { return lifeProp; }
        set {
            lifeProp = value;
            life.text = lifeProp.ToString();
        }
    }

}
