using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{

    private Board board;
    public Text scoreText;
    public int score;
    public Image scoreBar;
    public ParticleSystem particleSys; //teste
    public Slider slider; //teste

    //teste
    public void awake(){
        slider = gameObject.GetComponent<Slider>(); 
        //particleSys = gameObject.GetComponent<ParticleSystem>();
    }

    void Start(){
        board = FindObjectOfType<Board>();
        slider = FindObjectOfType<Slider>();//teste
    }

    void Update(){
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int amountToIncrease){
        score += amountToIncrease;
        if(board != null && scoreBar != null){
            int length = board.scoreGoals.Length;
            scoreBar.fillAmount = (float)score / (float)board.scoreGoals[length - 1];
            slider.value = (float)score / (float)board.scoreGoals[length - 1];//teste
            if(!particleSys.isPlaying){
                particleSys.Play();
            }else{
                particleSys.Stop();
            }
        }
    }
   
}
