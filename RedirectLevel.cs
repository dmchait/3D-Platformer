using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevel : MonoBehaviour {
    public GameObject fadeIn;
    public static int currentLevel;
    public static int nextLevel;

    public void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(FadeInOff());
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
