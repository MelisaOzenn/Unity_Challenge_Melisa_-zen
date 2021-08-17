using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskLight : MonoBehaviour
{
    public GameObject light;
    private bool on = true;
    public Text text;
    public GameObject canvas;

    void showText(){
        text.text = "Click to Turn On/Off Light";
    }

    void OnTriggerEnter(Collider player) {
        if(player.tag == "Player"){
            canvas.SetActive(true);
            showText();
        }
    }

    void OnTriggerStay(Collider player) {
        if (player.tag == "Player" && Input.GetMouseButtonDown(0) && !on){
            light.SetActive(true);
            on = true;
        }
        else if (player.tag == "Player" && Input.GetMouseButtonDown(0) && on){
            light.SetActive(false);
            on = false;
        }
    }

    void OnTriggerExit(Collider player) {
        canvas.SetActive(false);
    }
}
