using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3b : MonoBehaviour
{

    /*/b) Crea un m�todo para realizar operaciones matem�ticas, pas�ndole dos variables
    num�ricas.Desarrolla m�s el m�todo para que devuelva una variable booleana que
    devuelve true si el resultado es uno u otro (el que t� elijas, poni�ndlo en los comentarios)*/


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
