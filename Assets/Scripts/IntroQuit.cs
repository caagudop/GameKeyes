using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroQuit : MonoBehaviour
{
    public void toGame()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
