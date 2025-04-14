using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    int bounceCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bounceCount++;
            Debug.Log("Bounce Count: " + bounceCount);
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
