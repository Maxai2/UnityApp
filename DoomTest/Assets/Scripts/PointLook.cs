using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointLook : MonoBehaviour {
    public Text point;

    private int pointProp;
    public int PointProp {
        get { return pointProp; }
        set {
            pointProp = value;
            point.text = pointProp.ToString();
        }
    }

}
