using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class timerManager : MonoBehaviour
{

    public GameObject player;
    public playerHealth playerHealth;
    public TextMeshProUGUI timerText;
    public float currentTime;

    
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString();

        SetTimerText();

        if (playerHealth.isPlayerAlive == false)
        {
          
        }
    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
