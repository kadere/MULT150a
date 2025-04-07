using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    private int healthpoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

       
        Debug.Log("Health after using potions: " + healthpoints);
    }

    
    void Update()
    {
        
    }

   
    int UsePotion(int health)
    {
        health += 400;  
        return health;  
    }
}