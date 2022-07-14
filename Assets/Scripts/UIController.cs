using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gamePlay");
    }
    public void HomeButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
