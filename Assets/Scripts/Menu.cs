using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour
{
    public Canvas quitMenu;
    public Button play;
    public Button exit;//exit form the game
    void Start()
    {
        quitMenu.enabled = false;
    }
    public void ExitPress()
    {
        quitMenu.enabled = true;
        play.enabled = false;
        exit.enabled = false;
    }
    public void NoPress()
    {
        quitMenu.enabled = false;
        play.enabled = true;
        exit.enabled = true;
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();//exit from the game
    }
}
