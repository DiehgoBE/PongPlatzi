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
        //Deguggear para ver en donde se encuentra nuestra posición del mouse
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
        //transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);

        //Limitar el movimiento del personaje solo en el eje Y y mantener fijo el eje X
        //transform.position = new Vector3(transform.position.x, mousePos.y, transform.position.z);

        //Definir el limite max y min del Eje Y para evitar que se salga de la pantalla
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePos.y,-3.8f,3.8f), transform.position.z);





    }


    //Posible solución No HardCode
    /*SpriteRenderer playerSpriteRender;

    void Start()
    {
        playerSpriteRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x = transform.position.x;
        mousePos.y = Mathf.Clamp(mousePos.y, LimitDown(), LimitUp());
        mousePos.z = transform.position.z;
        transform.position = mousePos;
    }

    float LimitDown()
    {
        return -CameraBounds().y + playerSpriteRender.bounds.extents.y - 0.2f;
    }

    float LimitUp()
    {
        return CameraBounds().y - playerSpriteRender.bounds.extents.y + 0.2f;
    }

    Vector2 CameraBounds()
    {
        return Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
    */









}
