using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

    public GameObject scoreBox;
    public GameObject gemBox;
    public static int currentScore, gemAmount;
    public int internalScore;
	
	// Update is called once per frame
	void Update () {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;
        gemAmount = FinishLevel.gemsCollected;
        gemBox.GetComponent<Text>().text = "Gems x " + gemAmount;
    }
}
