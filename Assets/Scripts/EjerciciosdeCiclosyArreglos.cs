using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo1 = new int[10];
        for (int i = 0; i < miArreglo1.Length; i++)
        {
            miArreglo1[i] = Random.Range(1, 101);


        }

        int[] miArreglo2 = new int[10];
        for (int i = 0; i < miArreglo2.Length; i++)
        {
            miArreglo2[i] = Random.Range(1, 101);
        }

        int[] sumaDeArreglos = new int[10];
        {
            for (int i = 0; i < sumaDeArreglos.Length; i++)
            {
                sumaDeArreglos[i] = miArreglo1[i] + miArreglo2[i];
                Debug.Log(sumaDeArreglos[i]);
            }

        }

        string[] oracion = new string[5]
        {
            "I", "am", "the", "danger", "Skyler"
        };
        string creadorDeOracion = string.Join(", ", oracion);
        Debug.Log(creadorDeOracion);

        int[,] arregloBidimensional = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] arregloUnidimensional = { 2, 3, 4 };

      //  int producto1 = arregloBidimensional[0, 0] * arregloUnidimensional[0] + arregloBidimensional[0, 1] * arregloUnidimensional[1] + arregloBidimensional[0, 2] * arregloUnidimensional[2];
      //   int producto2 = arregloBidimensional[1, 0] * arregloUnidimensional[0] + arregloBidimensional[1, 1] * arregloUnidimensional[1] + arregloBidimensional[1, 2] * arregloUnidimensional[2];
      //  Debug.Log(producto1 + "\n" + producto2);



        // Multiply each value in arr2D with the corresponding value in arr1D
        int[] Resultado = new int[arregloUnidimensional.GetLength(0)]; // Create a new array to store the result

        for (int i = 0; i < arregloBidimensional.GetLength(0); i++)
        {
            int product = 0;
            for (int j = 0; j < arregloBidimensional.GetLength(1); j++)

                product += arregloBidimensional[i, j] * arregloUnidimensional[j];

            Resultado[i] = product;
        }
        for (int i = 0; i < Resultado.Length; i++)
        {
            Debug.Log(Resultado[i] + " ");
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
