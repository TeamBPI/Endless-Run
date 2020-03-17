﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject farBackground1, farBackground2, middleBackground1, middleBackground2, closeBackground1, closeBackground2;

    private void Start()
    {
        FarBackground2();
        MiddleBackground2();
        CloseBackground2();
        
        
        StartCoroutine(ParallaxFarBackground());
        StartCoroutine(ParallaxMiddleBackground());
        StartCoroutine(ParallaxCloseBackground());
    }
 
    private void FarBackground1()
    {
        Instantiate(farBackground1, new Vector3(19.4960f, -0.022f, 24.92969f), Quaternion.identity);
    }
    private void FarBackground2()
    {
        Instantiate(farBackground2, new Vector3(19.4960f, -0.022f, 24.92969f), Quaternion.identity);
    }
    private void MiddleBackground1()
    {
        Instantiate(middleBackground1, new Vector3(19.4939f, -1.45f, 24.92969f), Quaternion.identity);
    }
    private void MiddleBackground2()
    {
        Instantiate(middleBackground2, new Vector3(19.4939f, -1.45f, 24.92969f), Quaternion.identity);
    }
    private void CloseBackground1()
    {
        Instantiate(closeBackground1, new Vector3(19.39f, -4.219f, 24.92969f), Quaternion.identity);
    }
    private void CloseBackground2()
    {
        Instantiate(closeBackground2, new Vector3(19.39f, -4.219f, 24.92969f), Quaternion.identity);
    }

    IEnumerator ParallaxFarBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(42.652f);
            FarBackground1(); 

            yield return new WaitForSeconds(42.652f);
            FarBackground2();
        }
    }

    IEnumerator ParallaxMiddleBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(19.18f);
            MiddleBackground1();

            yield return new WaitForSeconds(19.18f);
            MiddleBackground2();
        }
    }

    IEnumerator ParallaxCloseBackground()
    {
        while (true)
        {
            yield return new WaitForSeconds(7.63f);
            CloseBackground1();

            yield return new WaitForSeconds(7.63f);
            CloseBackground2();
        }
    }


}