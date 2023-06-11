using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{
  public  void Replay ()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}   
