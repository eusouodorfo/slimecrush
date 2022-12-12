using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;
    private float targetProgress = 0;

    public void awake(){
        slider = gameObject.GetComponent<Slider>(); 
        particleSys = GameObject.Find("ProgressParticle").GetComponent<ParticleSystem>();
    }

    public void IncrementProgress(float newProgress){
        targetProgress = slider.value + newProgress;
    }
   
}
