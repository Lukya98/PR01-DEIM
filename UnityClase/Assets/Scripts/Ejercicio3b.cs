using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{

    /*/b) Crea un método para realizar operaciones matemáticas, pasándole dos variables
    numéricas.Desarrolla más el método para que devuelva una variable booleana que
    devuelve true si el resultado es uno u otro (el que tú elijas, poniéndlo en los comentarios)*/


    [SerializeField] int n1;
    [SerializeField] int n2;

    bool devolver;      //Variable booleana que devuelve el resultado

    int Resultadofinal;



    // Start is called before the first frame update
    void Start()
    {

        Matematica();

    }



    // Update is called once per frame
    void Update()
    {
        
    }



    //metodo operaciones matematicas
    void Matematica()
    {
        Resultadofinal = n1 + n2;
       
        if (Resultadofinal <= 5)
        {
            devolver = true;
        }
        else
        {
            devolver = false;
        }

        print("El resultado es: " + devolver);

        return;
    }

}
