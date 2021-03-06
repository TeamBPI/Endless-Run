﻿using UnityEngine;

public class FishScale : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2, EnemyFishType3; // рыбы, которые меняют размер
    float x, y; // координаты для рандом скейла


    void FixedUpdate() //тут вызывается изменение размера рыбы
    {
        SizeOfFish(EnemyFishType1, EnemyFishType2, EnemyFishType3);
    }

    private void SizeOfFish(GameObject EnemyFishType1, GameObject EnemyFishType2, GameObject EnemyFishType3) //функция изменения рыбы
    {
        //у объекта EnemyFishType меняется scale по X и Y
        x = Random.Range(-0.8f,-0.9f);
        y = x;        
        EnemyFishType1.transform.localScale = new Vector2(x, -y);

        x = Random.Range(1f, 1.1f);
        y = x;
        EnemyFishType2.transform.localScale = new Vector2(x, y);

        x = Random.Range(0.7f, 0.8f);
        y = x;
        EnemyFishType3.transform.localScale = new Vector2(x, y);
    }
}
