using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer = null;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}