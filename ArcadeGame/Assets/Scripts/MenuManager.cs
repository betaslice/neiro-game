using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadSong(string songID)
    {
        GlobalVars.songToLoad = songID;
        SceneManager.LoadScene("Gameplay");
    }
}