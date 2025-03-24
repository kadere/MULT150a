using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {int x = TakeDamageFromFireball (0) ;

    print ("Player health: " + x);
    int y = TakeDamageFromFireball (25) ; print ("Player health: " + y);

    int z = TakeDamageFromFireball(30, 50); print ("Player health: " + z);
        
    }

    // Update is called once per frame
 void Update()
    {
        
    }

    
    public int TakeDamageFromFireball(int damageAmount)
    {
        int health = 100;
        health -= damageAmount;
        return health;
    }

   
    public int TakeDamageFromFireball(int damageAmount, int currentHealth)
    {
        currentHealth -= damageAmount;
        return currentHealth;
    }

    
    public float TakeDamageFromFireball(int damageAmount, float damageMultiplier)
    {
        float totalDamage = damageAmount * damageMultiplier;
        return totalDamage;
    }
}