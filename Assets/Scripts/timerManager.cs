using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
//Elliott
public class timerManager : MonoBehaviour
{

    public GameObject player;
    public playerHealth playerHealth;
    public TextMeshProUGUI timerText;
    private bool counting = true;
    public float currentTime;

    
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counting == true) 
        {
            currentTime = currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString();
            SetTimerText(currentTime);
        }
       

        

        if (playerHealth.isPlayerAlive == false)
        {
            counting = false;
            SetTimerText(currentTime);
        }
    }

    public void SetTimerText(float currentTime)
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
