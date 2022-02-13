using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void QualitySet (int qualityNumber)
    {
        QualitySettings.SetQualityLevel(qualityNumber); 
    }

    public void VolumeSet (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void Fullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
