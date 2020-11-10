using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Para ver en donde se encuentra nuestra posición del mouse
        Debug.Log(Input.mousePosition); 

        //Asignar la posición del mouse (Pixel Coordenates) a la posición del transform (X,Y,Z) (World Coordenates)
        //transform.position = Input.mousePosition; 


        //Traducir las coordenadas de posición en Pixel a las coordenadas en el Mundo
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

        //Creamos una nueva variable que contenga la traducción de coordenadas
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

        //Creamos un nuevo vector3 para tener un valor especifico en X, Y y mantener el valor de Z 
        //Sino Z se colocá automaticamente en -10 lo cual hace que no se visualice en pantalla
        //Los objetos no pueden estar a la misma altura que la camara porque sino no se visualizan
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z); 
    }
}
