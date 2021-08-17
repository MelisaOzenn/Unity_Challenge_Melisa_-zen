using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public CharacterController controller;

    void Update()
    {
        float x  =Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x) + (transform.forward * z);

        controller.Move(move * speed * Time.deltaTime);
        
        if (transform.position.y != 0) {
         transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }
}
