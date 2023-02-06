using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo3script : MonoBehaviour
{
    public CambiodeColorRGB detectordevalor;
    public CambiodeColorRGB detectordevalor2;
    Renderer ren;
    public bool Valor;

    void Start()
    {
        detectordevalor = GameObject.Find("Cube (1)").GetComponent<CambiodeColorRGB>();
        detectordevalor2 = GameObject.Find("Cube (2)").GetComponent<CambiodeColorRGB>();
    }

    void FixedUpdate()
    {
        Valor = !Valor;
            

        if (detectordevalor && detectordevalor2 == true)
        {
            Debug.Log("El valor es de los 2 cybos es verdadero");
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            
        }
        else if (detectordevalor && detectordevalor2 == false);
        {
            Debug.Log("El valor de los 2 cubos es falso");
            ren = GetComponent<Renderer>();
            ren.material.color = Color.black;
           

        }
    }
}