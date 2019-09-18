using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversePlayer : MonoBehaviour {

    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
