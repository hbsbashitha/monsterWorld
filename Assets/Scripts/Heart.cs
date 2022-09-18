using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public Text hearts;
    public static int HeartValue = 3;
    

    // Update is called once per frame
    void Update()
    {
        // score.text = "Score: " + scoreValue;
        hearts.text = "Hearts: " + HeartValue;
    }


      private void OnTriggerEnter2D (Collider2D collision) {
        if(collision.gameObject.tag == "Player"){

            HeartValue += 1;
            hearts.text = "Hearts: " + HeartValue;
            // score.text = "Score: " + scoreValue;
            // Debug.Log("Heart: " + HeartValue);
            Destroy(gameObject);
        }
      
    }
}
