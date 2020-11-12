using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Extensión para cargar escenas distintas o volver a cargar la misma escena

public class DeadZone : MonoBehaviour
{
    //Función que detecta el choque con la colisión
    //El nombre de la variable es collision pero puede ser nombrado como uno quiera
    //En algunos casos el nombre de la variable puede ser col u other
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug que imprime un mensaje al darse la acción
        Debug.Log("Colisión");
    }

    //Función que detecta que el objeto atravesó la colisión
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug que imprime un mensaje al darse la acción
        Debug.Log("Trigger");
    }





}
