using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool gamePaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gamePaused) { pauseMenu.SetActive(true); gamePaused = true; Time.timeScale = 0;}
            else { pauseMenu.SetActive(false); gamePaused = false; Time.timeScale = 1; }
        } 
    }
}
