using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAttach : MonoBehaviour {

    CoinCounter cointCounter;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {
            cointCounter = collision.GetComponent<CoinCounter>();
            cointCounter.Coins += 1;

            Destroy(gameObject);
        }
    }
}
