using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Start Game!!");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!!");
    }
}
