using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{

    private int score;
    private bool ispaused=false;
    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Application.Quit();
            score = score + 5;

            if(score == 15){
            Debug.Log("Finito");
            Application.Quit();
        }
        }

        
    }

    
}