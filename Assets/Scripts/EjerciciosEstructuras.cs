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
    Stack<string> breakingBad = new Stack<string>();
    Queue<string> badBreaking = new Queue<string>(); 

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

    public void BreakingBad()
    {

        // El Primero que vea breakig bad es el ultimo que termina viendolo (FILO)
        breakingBad.Push("Skyler");
        breakingBad.Push("Danger,");
        breakingBad.Push("The");
        breakingBad.Push("Am");
        breakingBad.Push("I");
        Debug.Log(breakingBad.Peek());
        string Sky = breakingBad.Pop();
        Debug.Log(breakingBad.Peek());
        string Dan = breakingBad.Pop();
        Debug.Log(breakingBad.Peek());
        string The = breakingBad.Pop();
        Debug.Log(breakingBad.Peek());
        string Am = breakingBad.Pop();
        Debug.Log(breakingBad.Peek());
        string I = breakingBad.Pop();

        //El primero en ver breaking bad es el primero que lo acaba (FIFO)

        badBreaking.Enqueue(I);
        badBreaking.Enqueue(Am);
        badBreaking.Enqueue(The);
        badBreaking.Enqueue(Dan);
        badBreaking.Enqueue(Sky);
        Debug.Log(badBreaking.Peek());
        badBreaking.Dequeue();
        Debug.Log(badBreaking.Peek());
        badBreaking.Dequeue();
        Debug.Log(badBreaking.Peek());
        badBreaking.Dequeue();
        Debug.Log(badBreaking.Peek());
        badBreaking.Dequeue();
        Debug.Log(badBreaking.Peek());
        badBreaking.Dequeue();
    }
}

