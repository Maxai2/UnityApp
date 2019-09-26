using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour {
    public Text lt;

    private void Start() {
        lt.enabled = false;
    }

    public void ShowText(bool showHidden) {
        lt.enabled = showHidden;
    }
}
