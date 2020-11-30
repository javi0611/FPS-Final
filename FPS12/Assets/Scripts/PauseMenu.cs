using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour{


    public static bool isGamePaused = false;
    public GameObject pauseMenu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isGamePaused)
            {
                
                ResumeGame();
            } 
            else
            {
                
                PauseGame();
            }
        }
    }
    public void ResumeGame()
    {
       
        pauseMenu.SetActive(false);

        Time.timeScale = 1f;
        isGamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
       
    }
    void PauseGame()
    {
       
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    public void LoadMenu()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("IntroMenu");
    }
    public void QuitGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Application.Quit();
        Debug.Log("Quit");
    }

}
