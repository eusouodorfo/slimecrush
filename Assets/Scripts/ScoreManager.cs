using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{

    public Text scoreText;
    public int score;

    void Update(){
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int amountToIncrease){
        score += amountToIncrease;
    }
   
}
