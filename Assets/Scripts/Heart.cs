using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }


      private void OnTriggerEnter2D (Collider2D collision) {
        if(collision.gameObject.tag == "Player"){

            scoreValue += 1;
            score.text = "Score: " + scoreValue;
            Debug.Log("Score: " + scoreValue);
            Destroy(gameObject);
        }
        
           
        
    }
}
