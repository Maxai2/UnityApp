using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour {

    public float speed = 10.0f;
    public int damage = 1;
    
    void Update() {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();

        if (player != null) {
            Debug.Log("Player hit");

            //StartCoroutine(player.Hurt(damage));
            player.Hurt(damage);
        }

        Destroy(this.gameObject);
    }
}
