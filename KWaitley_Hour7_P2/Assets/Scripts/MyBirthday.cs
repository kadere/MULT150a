using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  int birthdayDay = 15;
       for (int i = 1; i <= 31; i++)
       if (i == birthdayDay)
       Debug.Log("It's my birthday!");
       else
       Debug.Log(i);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
