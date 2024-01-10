using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUI : MonoBehaviour  
{

    [SerializeField]
    private string NewGameLevel = "Level1";

    public void NewGameButton()
    {
        SceneManager.LoadScene(NewGameLevel);        
    }
}
