using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{

    static void Funcion(string[] args)
    {
        List<int> milista = new List<int>();
        int numero1 = 4;
        int numero2 = 4;
        int numero3 = 9;
        LlenadordeLista(numero1, numero2, numero3);

         void LlenadordeLista(int count, int min, int max)
         {

            for (int i = 0; i < count; i++)
            {
                int numeroAlAzar = Random.Range(min, max);
                milista.Add(numeroAlAzar);

               
            }

            foreach (int i in milista)
            {
                Debug.Log(i);
            }
         }
       


    }

}
