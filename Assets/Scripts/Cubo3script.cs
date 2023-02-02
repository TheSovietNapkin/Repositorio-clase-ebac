using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo3script : MonoBehaviour
{
    public GameObject prefab;
    private Renderer renderer;
    bool Valor;
    Renderer ren;

    private void Start()
    {
        renderer = prefab.GetComponent<Renderer>();
        Valor = true;
    }

    private void FixedUpdate()
    {
       
        if (renderer.material.color != Color.white && Valor == true)
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            Debug.Log("la variable es verdadera");
            Valor = !Valor;
        }
        else if (renderer.material.color != Color.black && Valor == false)
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            Debug.Log("La variable es falsa");
            Valor = !Valor;
           
        }
    }
}