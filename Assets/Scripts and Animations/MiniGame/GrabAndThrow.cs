using UnityEngine;
using System.Collections;

public class GrabAndThrow : MonoBehaviour
{
    public Transform dest;

    void OnMouseDown() {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

    void OnMouseUp() {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;

    }







}

