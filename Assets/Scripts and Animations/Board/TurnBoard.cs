using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBoard : MonoBehaviour
{   
    public Animator anim;
    public Text text;
    public GameObject canvas;
    
    void Start(){
        anim = GetComponent<Animator>();
    }

    void showText(){
        text.text = "Click to Turn Board";
    }


    void OnTriggerStay(Collider player) {   
        if (player.tag == "Player" ){
            canvas.SetActive(true);
            showText();
            if(Input.GetMouseButtonDown(0)){
                anim.SetTrigger("turn");
            }
        }
    }

    void OnTriggerExit(Collider player) {
        canvas.SetActive(false);
    }   
}

