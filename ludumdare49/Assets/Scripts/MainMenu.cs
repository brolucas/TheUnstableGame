using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string leveltoload;
    public GameObject settingsWIndow;

   public void StartGame()
    {
        SceneManager.LoadScene(leveltoload);
    }
    public void Settings()
    {
        settingsWIndow.SetActive(true);

    }

    public void CloseSettingsWindow()
    {
        settingsWIndow.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
