using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    Scene currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    public void loader(int scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void Intermission()
    {
        SceneManager.LoadScene("Intermission");
    }

    public static void StartGame()
    {
        SceneManager.LoadScene("Office");
    }

    public static void Win()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public static void Lose()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
