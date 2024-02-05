using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI : MonoBehaviour  
{

    [SerializeField]
    private string Level1 = "Level1", Level2 = "Level2", MainMenu = "MainMenu", Level3 = "Level3", Level4 = "Level4", Intro = "Intro", WinScreen = "WinScreen";


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ChangeLevel1()
    {
        SceneManager.LoadScene(Level1);        
    }

    public void ChangeLevel2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void ChangeLevelMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }
    public void ChangeLevel3()
    {
        SceneManager.LoadScene(Level3);
    }
    public void ChangeLevel4()
    {
        SceneManager.LoadScene(Level4);
    }
    public void ChangeLevelIntro()
    {
        SceneManager.LoadScene(Intro);
    }
    public void ChangeLevelWinScreen()
    {
        SceneManager.LoadScene(WinScreen);
    }
}
