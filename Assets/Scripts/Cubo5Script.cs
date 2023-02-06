using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5Script : MonoBehaviour
{
    public Cubo3script detectordevalor;
    public Cubo4Script detectordevalor2;
    Renderer ren;
    public bool Valor;

    void Start()
    {
        detectordevalor = GameObject.Find("Cube (3)").GetComponent<Cubo3script>();
        detectordevalor2 = GameObject.Find("Cube (4)").GetComponent<Cubo4Script>();
    }

    void FixedUpdate()
    {

       

        if (detectordevalor || detectordevalor2 == true)
        {
            Debug.Log("El valor es de los 2 cybos es verdadero");
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
          
        }
        else if (detectordevalor || detectordevalor2 == false) ;
        {
            Debug.Log("El valor de los 2 cubos es falso");
            ren = GetComponent<Renderer>();
            ren.material.color = Color.black;
           
        }
    }
}

