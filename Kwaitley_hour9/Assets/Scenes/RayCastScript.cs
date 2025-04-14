using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");

        // Rotate camera based on mouse movement
        transform.Rotate(dirY, -dirX, 0);

        CheckForRaycastHit();
    }

    void CheckForRaycastHit()
    {
        RaycastHit hit;

        // Send a ray forward from the camera
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}
