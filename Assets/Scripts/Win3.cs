using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win3 : MonoBehaviour
{
    public GameObject WinScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            WinScreen.SetActive(true);
        }
    }
}

