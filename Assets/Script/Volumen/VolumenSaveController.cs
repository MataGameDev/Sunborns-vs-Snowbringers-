using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumenSaveController : MonoBehaviour
{
    public AudioMixer mixeador;
    public Slider mainSlider;
    private static float oldValue = 1.0f;
    private void Start()
    {
        mainSlider.value = oldValue;
    }
    public void saveValue()
    {
        oldValue = mainSlider.value;
    }
    public void volumenSlider(float sliderValue)
    {
        mixeador.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
