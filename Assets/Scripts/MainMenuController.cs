using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{ 
  public void PlayGame(){
   int clickedPlayer= int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
    
    
    GameManager.instance.PlayerIndex = clickedPlayer;
    UnityEngine.SceneManagement.SceneManager.LoadScene("gamePlay");
  }
}
