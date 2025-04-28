using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
       public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {    {
       
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = transform.position + new Vector3(i * 2.0f, 0, 0); // 2 units apart
            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }

        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);

       
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(prefab, transform.position, transform.rotation);
        
    }
}
