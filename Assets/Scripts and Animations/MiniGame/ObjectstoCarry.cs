using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectstoCarry : MonoBehaviour
{
    public Transform sp1, sp2, sp3, sp4, sp5;
    public GameObject Prefab;
    public GameObject canvas;

    void OnTriggerStay(Collider player){
        if((player.tag == "Player")&&(Input.GetMouseButtonDown(0))){
            Instantiate(Prefab, sp1.position, sp1.rotation);
            Instantiate(Prefab, sp2.position, sp2.rotation);
            Instantiate(Prefab, sp3.position, sp3.rotation);
            Instantiate(Prefab, sp4.position, sp4.rotation);
            Instantiate(Prefab, sp5.position, sp5.rotation);
            canvas.SetActive(true);
        }
    }

}