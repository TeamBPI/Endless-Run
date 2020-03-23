﻿using UnityEngine.SceneManagement;
using UnityEngine;


public class Evolution : MonoBehaviour
{

    public GameObject PlayerFish2, PlayerFish;
    public GameObject scoreValue;
    int scoreForEvol = 0;
    
    public int scoreGoal;

    public GameObject spawnEnemy;    

    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
        audioSource = GetComponent<AudioSource>();
    }


    private bool isEvolve = false;
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        
        if (scoreForEvol == scoreGoal) 
        {
            isEvolve = true;
            PlayerFish.SetActive(false);
            PlayerFish2.SetActive(true);
            SoundForEvolve(isEvolve);
        }
    }

    [SerializeField]
    private AudioClip clip;
    AudioSource audioSource;

    private void SoundForEvolve(bool isEvolve)
    {
        if (isEvolve)
            audioSource.PlayOneShot(clip);
    }
}
    