using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   float health;
    float poisonDamage;

    // Start is called before the first frame update
    void Start()
    {  health = 1004f;        
       poisonDamage = 125.5f;
       Debug.Log(health);
       
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       health -= poisonDamage;
       Debug.Log(health);
       if (health <= 0);
      Debug.Log("Player has been unalived!");


       
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
