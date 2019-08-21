using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Math : MonoBehaviour {

    public GameObject ScoreText;
    public static double theScore;
    
    // Update is called once per frame
    void Update () {
        ScoreText.GetComponent<Text>().text = "SCORE: " + theScore;
	}
}
