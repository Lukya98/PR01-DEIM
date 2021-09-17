using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_variables : MonoBehaviour
{
    //Ejercicio 1a
    private int myint = 10;
    private float myfloat = 2.5f;
    private string mystring = "Hola me da miedo el codigo";
    private bool mybool = true;
    //Ejercicio 1b
    public int myintp = 10;
    public float myfloatp = 2.5f;
    public string mystringp = "Hola me da miedo el codigo";
    public bool myboolp = true;
    //Ejercicio 1c
    public float myfloatp2 = 3.3f;
    public float myfloatp3 = 2.7f;
    public float myresult;



    




    // Start is called before the first frame update
    void Start()
    {
        //ejercicio 1b
        print(myboolp);
        print(mystringp);
        print(myintp);
        print(myfloatp);
        //ejercicio 1c
        myresult = myfloatp2 + myfloatp3;
        Debug.Log(myresult);

        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
