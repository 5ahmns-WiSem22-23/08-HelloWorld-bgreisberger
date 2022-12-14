using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //2) Instanzvariable nutzen
    private int startValue2 = 0;

    //3) der Wert der dazugezählt wird ist bei Deklaration noch nicht bekannt
    // z.B. Random oder User Input
    private int startValue3 = 0;

    //4) Copy by Value
    private int startValue4 = 10;

    //5) Return
    private int startValue5 = 20;


    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2) Instanzvariable nutzen
        Debug.Log("before startValue2:" + startValue2);
        IncrementByOne();
        Debug.Log("after startValue2:" + startValue2);

        //at 3)
        Debug.Log("before startValue3:" + startValue3);
        IncrementByX(Random.Range(1,10));
        Debug.Log("after startValue3:" + startValue3);

        //at 4)
        Debug.Log("before startValue4:" + startValue4);
        OutputDecrementedValue(startValue4);
        Debug.Log("after startValue4:" + startValue4);

        //at 5)
        Debug.Log("before startValue5:" + startValue5);
        startValue5 = GetDiffrence(startValue5, 2);
        Debug.Log("before startValue5:" + startValue5);
    }
    

    //5) incl. return value 
    private int GetDiffrence(int a, int b)
    {
        return a - b;

    }

    //at 4)
    private void OutputDecrementedValue(int val)
    {
        val--;
        Debug.Log("val:" + val);
    }

    //3)
    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;

    }

    //2)
    private void IncrementByOne()
    {
        startValue2++;

    }

}
