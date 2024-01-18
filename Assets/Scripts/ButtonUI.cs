using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI : MonoBehaviour  
{

    [SerializeField]
    private string NewGameLevel = "Level1", NewGameLevel2 = "Level2", NewGameLevel0 = "MainMenu", NewGameLevel3 = "Level3", NewGameLevel4 = "Level4";


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NewGameButton1()
    {
        SceneManager.LoadScene(NewGameLevel);        
    }

    public void NewGameButton2()
    {
        SceneManager.LoadScene(NewGameLevel2);
    }

    public void NewGameButton0()
    {
        SceneManager.LoadScene(NewGameLevel0);
    }
    public void NewGameButton3()
    {
        SceneManager.LoadScene(NewGameLevel3);
    }
    public void NewGameButton4()
    {
        SceneManager.LoadScene(NewGameLevel4);
    }
}
