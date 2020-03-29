﻿using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Sprite enableSprite;
    public Sprite disableSprite;

    bool audioEnabled = true;
    public bool AudioEnabled { get { return audioEnabled; } set { SetAudio(value); } }

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void SetAudio(bool enabled)
    {
        if (enabled)
        {
            AudioListener.volume = 1f;
            image.sprite = enableSprite;
        }
        else
        {
            AudioListener.volume = 0f;
            image.sprite = disableSprite;
        }
        audioEnabled = enabled;
    }

    public void SwitchAudio()
    {
        AudioEnabled = !AudioEnabled;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public Slider slider;
    public Text valueCount;
    private void Update()
    {
        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value; 
    }

}