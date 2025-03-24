using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{ public float moveSpeed = 5f; 
    public float sensitivity = 2f; 
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

       
        transform.Translate(mouseX * sensitivity, mouseY * sensitivity, 0f, Space.World);
        
    }
}
