using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {

    public bool Shooted { get; set; }

    private void Start() {
        Shooted = false;
    }

    public void ReactToHit() {
        Shooted = true;

        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null) {
            behavior.SetAlive(false);
        }
        
        StartCoroutine(Die());
    }   

    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Shooted = false;
        Destroy(this.gameObject);
    }

}
