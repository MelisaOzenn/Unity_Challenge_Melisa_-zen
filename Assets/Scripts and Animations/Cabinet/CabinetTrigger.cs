using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabinetTrigger : MonoBehaviour
{
    [SerializeField]
    private CabinetAnimated cabinet;
    public Text text;
    public GameObject canvas;

    void showText(){
        text.text = "Press E to Open, F to Close Cabinet";
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.E)){
            cabinet.openCabinet();
        }
        else if(Input.GetKeyDown(KeyCode.F)){
            cabinet.closeCabinet();
        }
    }

        void OnTriggerEnter(Collider player) {
            if (player.tag == "Player" ){
                canvas.SetActive(true);
                showText();
            }
        }
        void OnTriggerExit(Collider player) {
            canvas.SetActive(false);
        }
}
