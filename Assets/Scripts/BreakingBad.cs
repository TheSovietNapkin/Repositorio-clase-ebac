using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBad : MonoBehaviour
{
    Stack<string> breakingBad = new Stack<string>();
    Queue<string> badBreaking = new Queue<string>();

    public void BD()
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
