using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_estructuras : MonoBehaviour
{
    //Ejercico 2d
    int minumero;
    int recuento;       //numero de veces que se genera un numero aleatorio

    // Start is called before the first frame update
    void Start()
    {
        recuento = 0;   //Valor de incial de recuento


        while (minumero != 5) //numero que se va a intentar conseguir de forma aleatoria
        {
            minumero = Random.Range(1, 101); //Generador de numeros

            Debug.Log("ha salido el numero: " + minumero); //Dice que numero ha salido
            recuento++; 
        }


        Debug.Log("Se acabó, han salido un total de: " + recuento + " números");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
