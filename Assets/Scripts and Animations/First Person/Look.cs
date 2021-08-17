using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float mouseSpeed = 200f;
    public Transform body;
    float xRotate = 0f; 

    void Start(){
        Cursor.lockState = CursorLockMode.None; //not the best option, but needed for button choices
    }                                           //can be improved

    void Update(){
        float xMovement = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSpeed *3;
        float yMovement = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSpeed *3;

        xRotate -= yMovement;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        body.Rotate(Vector3.up * xMovement);
    }
}
