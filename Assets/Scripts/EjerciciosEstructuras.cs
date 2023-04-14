using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    int numero1 = 4;
    int numero2 = 5;
    int numero3 = 9;
    List<int> milista = new List<int>();
    List<int> ordenadorNumeros = new List<int>();
    int[] listaNumeros = new int[6];
    HashSet<string> elementosRepetidos = new HashSet<string>()
    {"Heisenberg", "Heisenberg", "Jesse", "Skyler", "Skyler", "Gustavo" };
    HashSet<string> nombresUnicos = new HashSet<string>();
    HashSet<string> nombreDobles = new HashSet<string>();

    void Start()
    {
        

        foreach (string nombres in elementosRepetidos)
        {
            if (!nombresUnicos.Contains(nombres))
            {
                nombresUnicos.Add(nombres);
            }
            else
            {
                nombreDobles.Add(nombres);
            }
        }

        foreach (string nombres in nombresUnicos)
        {
            Debug.Log(nombres);
        }

        foreach (string duplicate in nombreDobles)
        {
            Debug.LogFormat("Duplicate: {0}", duplicate);
        }



        for (int e = 0; e < listaNumeros.Length; e++)
        {
            listaNumeros[e] = Random.Range(1, 20);
            ordenadorNumeros.Add(e);

        }
        ordenadorNumeros.Sort();

        foreach (int e in ordenadorNumeros)
        {
            Debug.Log(e);
        }

        for (int i = 0; i < numero1; i++)
        {
            int numeroAlAzar = Random.Range(numero2, numero3);
            milista.Add(numeroAlAzar);
            Debug.Log(numeroAlAzar);
        }
      





    }
}

