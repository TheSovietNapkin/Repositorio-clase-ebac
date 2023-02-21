using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    sbyte miBytConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 3;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0; 

    void Start()
    {
        int a, b, c;
        float f; 
        a = 10;
        b = 5;
        c = a + b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(c);

        miInt = Random.Range(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("El numero " + miInt + "es par");
        }
        else
        {
            Debug.Log("El numero " + miInt + "es non");
        }
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
