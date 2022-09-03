using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("gamePlay");
    }

    public void Home(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
