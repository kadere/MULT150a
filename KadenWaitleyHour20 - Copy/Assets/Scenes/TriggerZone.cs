using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
