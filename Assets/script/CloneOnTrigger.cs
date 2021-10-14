using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOnTrigger : MonoBehaviour
{
    public int cloneMax = 10;
    private int cloneCount = 0;


    void OnTriggerEnter(Collider other) {
        GameObject clone = Instantiate(other.gameObject); 
        bool check = clone.GetComponent<ScaleDownAndDestroy>() == null;
        if (check) {
            clone.AddComponent<ScaleDownAndDestroy>();
        }

        clone.GetComponent<ScaleDownAndDestroy>().duration = Random.Range(1f, 10f);
        
        cloneCount += 1;


        if (cloneCount == cloneMax) {
            Destroy(gameObject);
        }
    }
}
