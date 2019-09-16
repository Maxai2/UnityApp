using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnClick : MonoBehaviour {

    public void OnStartButton() {
        SceneManager.LoadScene("Level01");
    }

    public void OnExitButton() {
        Application.Quit();
    }

}
