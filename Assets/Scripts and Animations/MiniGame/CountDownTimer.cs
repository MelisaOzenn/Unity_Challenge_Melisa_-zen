using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime=0f;
    float startTime=30f;
    public Text countdown;
    bool timerActive = false;
    public GameObject canvas;

    void Start(){
        currentTime = startTime;
    }

    void Update(){        
            if(timerActive == true){
                currentTime = currentTime-Time.deltaTime;
            }
            countdown.text = currentTime.ToString("0");
            if(currentTime <= 0){
                currentTime = 0;
            }        
    }

    public void StartTimer(){
        timerActive = true;
    }

    public void CloseGame(){
        canvas.SetActive(false);
    }
}
