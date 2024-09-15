using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float countdownTime = 10f;
    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0f)
        {
            Debug.Log("Game Over - Time's up!");
        }
    }

    public void Victory()
    {
        Debug.Log("You Win - Mission Accomplished!");
    }
}