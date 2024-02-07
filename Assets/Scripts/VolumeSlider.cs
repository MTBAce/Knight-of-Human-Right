using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    private const string VolumePreferencesKey = "Volume";
    void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat(VolumePreferencesKey, 1.0f);

        SetVolume(savedVolume);
    }

    public void SetVolume(float volume)
    {
        if (audioMixer != null)
        {
            audioMixer.SetFloat("volume", volume);
        }
        PlayerPrefs.SetFloat(VolumePreferencesKey, volume);
    }

}