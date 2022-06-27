using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int X;
    // Start is called before the first frame update
    void Start()
    {
        X = 0;
        print("Hola Mundo");
        Debug.Log("Algo salio mal");
        Debug.LogError("Algo salio muy mal");
        Debug.LogWarning("Algo puede salir mal");

    }

    // Update is called once per frame
    void Update()
    {
        //X = X + 1;
        //Debug.Log(x);
        Debug.Log("Hola desde Update");

    }
    private void FixedUpdate()
    {
        Debug.Log("Hola desde Fixed Update");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El Objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido deshabilitado");
    }
}
