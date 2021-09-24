using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    /*a) En el anterior apartado has creado varios métodos, ¿serías capaz de lanzarlos cuando se
 pulse un botón (por ejemplo, que el contador se lance al pulsar un botón y se detenga con
 otro, aunque lo ideal es que sea con el mismo botón y usando una booleana)*/

    [SerializeField] Text Mytext;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            StartCoroutine("metodo1");
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            StartCoroutine("Cronometro");
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            StopCoroutine("Cronometro");
        }


    }
    //Metodo 1
    void metodo1()
    {
        int n1 = 1;
        int n2 = 2;
        int resultado0 = n1 + n2;
        print(resultado0);
        return;

    }
    //Contador
    IEnumerator Cronometro()
    {
        for (int n = 0; n <= 100; n++)
        {
            Mytext.text = "Contador: " + n;
            yield return new WaitForSeconds(1f);
            if (n == 9)
            {
                StopCoroutine("Cronometro");
            }
        }
    }
}
