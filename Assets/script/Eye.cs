using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public Transform target;
    public bool isFalling = false;
    public GameObject clone; 

    void Update() {
        if (target != null) {
            if (isFalling == false){
                transform.LookAt(target);
            }
            
        }
    }

    
     void OnMouseDown() {
        clone = Instantiate(gameObject, transform.parent);
        clone.SetActive(false);
        isFalling = true;
       Rigidbody body = gameObject.AddComponent<Rigidbody>();
       // "trainée angulaire", càd la friction associé a la rotation
       // 0.05f par défaut, nous mettons 0.2f pour ralentir les yeux.
       body.angularDrag = 0.8f;
       Debug.Log("i'm falliiiiiiiiiiiiing");

       StartCoroutine(FallEnd());
    }
    // pour retarder une action il faut écrire une fonctione IEnumerator// 
    IEnumerator FallEnd() {
        yield return new WaitForSeconds(4f);
        isFalling = false;
        Debug.Log("finally, it's ok, i'm still alive");
        clone.SetActive(true);
       
    }
}