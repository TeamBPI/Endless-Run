﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip clip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Began)))
        {
            audioSource.PlayOneShot(clip);
            Debug.Log("asd");
        }
    }
}