using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetAnimated : MonoBehaviour
{
    private Animator animator;
    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void openCabinet(){
        animator.SetBool("Open", true);
    }

    public void closeCabinet(){
        animator.SetBool("Open",false);
    }
    
    
    
}
