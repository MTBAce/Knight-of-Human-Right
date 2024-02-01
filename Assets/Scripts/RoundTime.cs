using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundTime : MonoBehaviour
{

    public GameObject player;
    GameObject timerManager;
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
        
    }
}
