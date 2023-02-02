using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5Script : MonoBehaviour
{
    public GameObject prefab;
    private Renderer renderer;
    bool Valor;
    Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        renderer = prefab.GetComponent<Renderer>();
        Valor = true;
    }
    private void FixedUpdate()
    {

        if (renderer.material.color != Color.white || Valor == true)
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            Debug.Log("la variable es verdadera");
            Valor = !Valor;
        }
        else if (renderer.material.color != Color.black || Valor == false)
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            Debug.Log("La variable es falsa");
            Valor = !Valor;

        }
    }
}

