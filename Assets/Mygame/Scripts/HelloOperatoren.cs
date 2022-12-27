using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    private bool a = false;
    private bool b = true;

    private int x = 4;
    private int y = 2;

    // Start is called before the first frame update
    void Start()
    {
     //  Arithmetische Operatoren

        //  Unäre Operatoren
        if (x + y == 6)
        {
            Debug.Log("x + y = 6");
        }

        if (x - y == 2)
        {
            Debug.Log("x - y = 2");
        }

        //  Binäre Operatoren
        if (x * y == 8)
        {
            Debug.Log("x * y = 8");
        }

        if (x / y == 2)
        {
            Debug.Log("x / y = 2");
        }

        //  Logische Operatoren

        //  Unäre Operatoren
        if (!a)
        {
            Debug.Log("a = true");
        }

        if (!!b)
        {
            Debug.Log("b = true");
        }

        //  Binäre Operatoren

        if (a && b)
        {
            Debug.Log("a&&b = true");
        }

        if (a || b)
        {
            Debug.Log("a|b = true");
        }

        if (a & b)
        {
            Debug.Log("a&b = true");
        }

        if (a | b)
        {
            Debug.Log("a|b = true");
        }

        

    }


}
