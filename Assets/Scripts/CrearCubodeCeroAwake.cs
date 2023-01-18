using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubodeCeroAwake : MonoBehaviour
{
    public GameObject Cubeprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Instantiate(Cubeprefab);
    }
}
