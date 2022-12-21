using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    private int x = 0;

    // Start is called before the first frame update
    void Update()
    {
        if (x == 0)
        {
            Debug.Log("ist 0");
            x = 2;
            return;
        }

        if (5 > x && x > 1)
        {
            Debug.Log("größer als 1");
            x = x+1;
            return;
        }

        else if ( x > 4)
        {
            Debug.Log("zwischen 4 und 8");
            x = 0;
            return;
        }
 
    }

    
}
