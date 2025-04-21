using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{ public bool isSolved = false;

    
    // Start is called before the first frame update
    void Start()
    {
     GameObject collidedWith = GetComponent<Collider>().gameObject;
             if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }


           

        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
