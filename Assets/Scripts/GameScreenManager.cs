using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreenManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void RestartGame(){
       Coin.scoreValue=0;
         Heart.HeartValue=3;
        UnityEngine.SceneManagement.SceneManager.LoadScene("gamePlay");
    }

    public void Home(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
