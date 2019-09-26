using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour {

    private int _health;

    LifeLook ll;

    void Start() {
        _health = 5;
            
        ll = GetComponent<LifeLook>();
        ll.LifeProp = _health;
    }
    
    public void Hurt(int damage) {

        _health -= damage;
        ll.LifeProp = _health;
        Debug.Log("Health: " + _health);

        if (_health == 0) {
            //Time.timeScale = 0;
            LoseScript ls = GetComponent<LoseScript>();

            ls.ShowText(true);


            //yield return new WaitForSeconds(0);


            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            SceneManager.LoadScene("Menu");
        }

    }
}
