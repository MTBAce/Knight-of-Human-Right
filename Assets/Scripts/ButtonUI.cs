using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI : MonoBehaviour  
{

    [SerializeField]
    private string NewGameLevel = "Level1", NewGameLevel2 = "Level2";

    public void NewGameButton1()
    {
        SceneManager.LoadScene(NewGameLevel);        
    }

    public void NewGameButton2()
    {
        SceneManager.LoadScene(NewGameLevel2);
    }

}
