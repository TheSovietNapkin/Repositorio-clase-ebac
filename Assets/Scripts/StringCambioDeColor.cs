using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringCambioDeColor : MonoBehaviour
{
    public string[] options = { "Heisenberg", "Gus", "Jesse", "Skyler", "Walter" };

    void Start()
    {
        
    // "Walter", "Hesienberg", "Jesse", "Gus", ""

    int randomIndex = UnityEngine.Random.Range(0, options.Length);

    string myString = options[randomIndex];

        Material material = GetComponent<Renderer>().material;

        switch (myString)
        {
            case "Heisenberg":
                Debug.Log("I am Hesienberg");
                material.color = Color.yellow;
                break;

            case "Walter":
                Debug.Log("Hey Walt");
                material.color = Color.blue;
                break;

            case "Jesse":
                Debug.Log("Science Bitch!");
                material.color = Color.red;
                break;

            case "Gus":
                Debug.Log("Welcome to los pollos hermanos");
                material.color = Color.gray;
                break;

            case "Skyler":
                Debug.Log("I am the danger skyler");
                material.color = Color.cyan;
                break;

            default:
                Debug.Log("Breaking Bad");
                material.color = Color.green;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
     

