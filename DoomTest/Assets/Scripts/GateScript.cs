using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateScript : MonoBehaviour
{
    public string lvlName;

    private void OnTriggerEnter(Collider other) {
        if (lvlName == "Menu") {
            WinScript ws = GetComponent<WinScript>();
            ws.ShowText(true);
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        SceneManager.LoadScene(lvlName);
    }
}
