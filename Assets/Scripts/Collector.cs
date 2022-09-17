using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private string ENEMY_TAG="Enemy";
    
    private void OnTriggerEnter2D(Collider2D target){
        if(target.tag == ENEMY_TAG){
            Destroy(target.gameObject);
        }
    }
}
