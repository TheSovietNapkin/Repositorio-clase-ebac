using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodeColorRGB : MonoBehaviour
{

   public bool variable2;


    Renderer ren;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        variable2 = !variable2;

        if (variable2 == true)
        {

            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
            Debug.Log("El valor es verdadero");
            
        }
        else if (variable2 == false) 
        {
            Debug.Log("El valor falso");
            ren = GetComponent<Renderer>();
            ren.material.color = Color.black;
            
        }
        
    }
}
