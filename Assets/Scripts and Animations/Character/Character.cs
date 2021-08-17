using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Animator animation;
    public Text text;
    public GameObject canvas;

    void Start() {
        animation = GetComponent<Animator>();
    }
    void showText(){
        text.text = "Click to Change Animation";
    }

    void OnTriggerStay(Collider player) {   
            if (player.tag == "Player" ){
                canvas.SetActive(true);
                showText();
                if(Input.GetMouseButtonDown(0)){
                    animation.SetTrigger("char");
                }
            }
    }

    void OnTriggerExit(Collider player) {
        canvas.SetActive(false);
    }
}


