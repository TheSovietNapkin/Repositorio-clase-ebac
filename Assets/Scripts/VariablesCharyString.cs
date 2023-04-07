using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharyString : MonoBehaviour
{


    void Start()
    {
        char c = '6';
        int valorEntero = 0;
        if (int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }

        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string miTercerString = miString + " " + miSegundoString;
       // string ejemploEscpae = "c:\\Users\\Ari\\Documentos";
        miCaracter = miString[13];
        string miNombre = "Ari Joseph";
        string misApellidos = "Seidel Martinez";
        string salida = $"Mi nombre es: {miNombre} Y mis Apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
