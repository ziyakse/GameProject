using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float countdownTime = 60f;
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
            // Implement game over logic here
        }
    }

    // Call this method when the player reaches the exit point
    public void Victory()
    {
        Debug.Log("You Win - Mission Accomplished!");
        // Implement victory logic here
    }
}