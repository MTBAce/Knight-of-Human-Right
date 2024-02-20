using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//Gustav, Elliott
public class Win : MonoBehaviour
{
    public GameObject WinScreen;
    public GameObject timeManager;
    public timerManager timerManager;
    public TextMeshProUGUI finalTime;
    public GameObject timeObject;


    private void Start()
    {
        timerManager = timeManager.GetComponent<timerManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            WinScreen.SetActive(true);
            timeObject.SetActive(false);
            finalTime.text = timerManager.currentTime.ToString("0.00");
        }
    }
} 


