using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void OnStartButton() {
        SceneManager.LoadScene("Level0");
    }

    public void OnExitButton() {
        Application.Quit();
    }
}
