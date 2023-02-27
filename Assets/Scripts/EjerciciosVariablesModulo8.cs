using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesModulo8 : MonoBehaviour
{
    int valor1 = 4;
    int a = 1;
    int b = 10;
    float valor2 = 3;
    float valor3 = 5;
    float valor4 = 8;
    float ValorSumadoFloat;
    int valorSumadoInt;
    int ValorParImpar;
    string valorParaParse1 = "3";
    string valorParaParse2 = "5";
    int sumaDeParse;
    string oracion = "Hola me gustaria saber quien no busco el riñon de gabriel";
    string output = "";
    string oracionParaEliminar = "meseemeth";

    float flotanteAString = 4.5657f;
    string flotanteEnString;
    string miNombre = "Ari Joseph Seidel";

    void Start()
    {


        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 1)
            {
                continue; 
            }
            output += oracion[i]; 
        }
        Debug.Log(output); 

        string primerNombre = miNombre.Substring(0, 3);
        Debug.Log("mi nombre es " + primerNombre);
        string segundoNombre = miNombre.Substring(4, 7);
        Debug.Log("mi segundo nombre es " + segundoNombre);
        string apellido = miNombre.Substring(11);
        Debug.Log("mi Apellido es " + apellido);
        ValorSumadoFloat = valor3 + valor4;
        valorSumadoInt = (int)ValorSumadoFloat;
        Debug.Log(valorSumadoInt);
        string flotanteEnString = flotanteAString.ToString("n4");
        Debug.Log(flotanteEnString);

        int num1, num2;

        if (int.TryParse(valorParaParse1, out num1) && int.TryParse(valorParaParse2, out num2))
        {
            sumaDeParse = num1 + num2;
            Debug.Log("la suma del parse es "+sumaDeParse);
           
        }

        string oracionEliminada = oracionParaEliminar.Substring(5);
        Debug.Log(oracionEliminada);
    }
    // Update is called once per frame
    void Update()
    {
        valor1 *= 3;
    //   Debug.Log(valor1);
    }

    private void FixedUpdate()
    {
        valor2 *= 3;
        //  Debug.Log(valor2);
        ValorParImpar = Random.Range(a, b);
        if (ValorParImpar % 2 == 0)
        {
            Debug.Log("El numero " +ValorParImpar+ " es par");
            Material material = GetComponent<Renderer>().material;
            material.color = Color.blue;
        }
        else
        {
            Debug.Log("El numero " +ValorParImpar + " es impar");
            Material material = GetComponent<Renderer>().material;
            material.color = Color.red;
        }
    }




}
