using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetActive : MonoBehaviour
{
    public void openCabinet(){
        gameObject.SetActive(false);
    }

    public void closeCabinet(){
        gameObject.SetActive(true);
    }
}
