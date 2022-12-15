using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("algo paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo Salio mediantemente mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Upadte cada 50 frames");

    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido deshabilitado");
    }
}
