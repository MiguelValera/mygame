using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Level 1");

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
