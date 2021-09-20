using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3a : MonoBehaviour
{
    string saludo = "hola";

    // Start is called before the first frame update
    void Start()
    {
        Saludar(saludo);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Saludar(string saludo)
    {
        print(saludo);
    }

}
