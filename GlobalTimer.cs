using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour {

    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public float timeRemaining = 180.0f;
    public bool timerIsRunning = false;
    public static int extendScore;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                float minutes = Mathf.FloorToInt(timeRemaining / 60);
                float seconds = Mathf.FloorToInt(timeRemaining - minutes * 60);
                extendScore = Mathf.FloorToInt(timeRemaining);

                timeDisplay01.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
                timeDisplay02.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
                
                if (FinishLevel.gameEnded == true)
                {
                    timerIsRunning = false;
                }
            }
            else
            {
                SceneManager.LoadScene(5);
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}
