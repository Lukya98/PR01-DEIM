using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    /*b) Añade un GameObject a la escena y haz que se desplace según los controles de tu
GamePad, tanto horizontalmente como verticalmente*/
    [SerializeField] float speed = 5;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);
        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desplX * Time.deltaTime);


    }
    
    
}
