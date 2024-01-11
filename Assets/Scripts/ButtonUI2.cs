using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI2 : MonoBehaviour  
{

    [SerializeField]
    private string NewGameLevel2 = "Level2";

    public void NewGameButton()
    {
        SceneManager.LoadScene(NewGameLevel2);        
    }
}
