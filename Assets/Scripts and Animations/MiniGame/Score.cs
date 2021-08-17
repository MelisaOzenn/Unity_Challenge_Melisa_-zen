using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float score = 0f;
    public Text scoreText;
    
    void Start(){
        //scoreText = GetComponent<Text>();
    }
    void OnTriggerEnter(Collider brain) {
        if(brain.tag == "Trash"){
            score++;
            scoreText.text = "Score: " + score;
        }
    }





}
