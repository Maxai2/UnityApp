using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateShowHidden : MonoBehaviour {
    public GameObject gate;

    private void Start() => gate.active = false;

    public void ShowGate() => gate.active = true;
}
