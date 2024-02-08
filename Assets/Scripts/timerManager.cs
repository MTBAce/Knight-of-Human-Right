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
    public TextMeshProUGUI finalTime;
    public GameObject timeObject;
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
            timeObject.SetActive(false);
        }
    }

    public void SetTimerText(float currentTime)
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
