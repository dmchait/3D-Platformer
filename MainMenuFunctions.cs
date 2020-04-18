using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour
{
    public AudioSource buttonPressed;
    public int highScore;
    public GameObject highScoreDisplay;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("LevelScore");
        highScoreDisplay.GetComponent<Text>().text = "High Score: " + highScore;
    }
    public void PlayGame()
    {
        buttonPressed.Play();
        RedirectLevel.currentLevel = 2;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCredits()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Credits");
    }
}
