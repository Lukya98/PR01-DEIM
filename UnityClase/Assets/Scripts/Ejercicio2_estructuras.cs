using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_estructuras : MonoBehaviour
{
    int numero1 = 1;



    // Start is called before the first frame update
    void Start()
    {
    while(numero1<=10)
        { 
            if (numero1 < 10)
           {
            print("el numero es menor que 10");
           }
            else if(numero1>= 5 && numero1<=10)
           {
            print("el numero es "+ numero1);
           }
             else
            {
            print("el numero es 10");

            }
            
            numero1++;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
