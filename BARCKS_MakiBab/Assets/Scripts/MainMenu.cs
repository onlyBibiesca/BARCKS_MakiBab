using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool isOptionsMenu = false;

    public GameObject ButtonsUI;
    public GameObject OptionsMenuUI;

    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Going to gameplay");
    }

    public void Options()
    {
        isOptionsMenu = true;
        OptionsMenuUI.SetActive(true);
        Debug.Log("Going to Options Menu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
