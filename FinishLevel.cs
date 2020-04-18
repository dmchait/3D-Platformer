using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic, levelTimer, timeLeft, theScore, finalScore, scoreBox, fadeOut;
    public AudioSource levelComplete;
    public int timeCalc, scoreCalc, totalScored;
    public static int gemsInLevel, gemsCollected;
    public static bool gameEnded = false;

    void OnTriggerEnter()
    {
        if (gemsCollected == gemsInLevel)
        {
            gameEnded = true;
            timeCalc = GlobalTimer.extendScore * 100;
            timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
            theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
            totalScored = GlobalScore.currentScore + timeCalc;
            finalScore.GetComponent<Text>().text = "Final Score: " + totalScored;
            PlayerPrefs.SetInt("LevelScore", totalScored);
            levelMusic.SetActive(false);
            levelTimer.SetActive(false);
            levelComplete.Play();
            StartCoroutine(CalculateScore());
        }
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        finalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        GlobalScore.currentScore = 0;
        GlobalScore.gemAmount = 0;
        gemsCollected = 0;
        gemsInLevel = 0;
        SceneManager.LoadScene(RedirectLevel.nextLevel);
    }
}
