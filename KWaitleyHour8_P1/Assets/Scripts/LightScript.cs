using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
     private Light lightbulb;
    // Start is called before the first frame update
    void Start()
    {
         lightbulb = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
          
        if (Input.GetKeyDown(KeyCode.L))
        {
            
            lightbulb.enabled = !lightbulb.enabled;
        }
        
    }
}
