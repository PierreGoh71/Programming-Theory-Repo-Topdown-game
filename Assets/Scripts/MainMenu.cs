using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {

        EditorApplication.ExitPlaymode();

        Application.Quit(); // original code to quit Unity player

    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
