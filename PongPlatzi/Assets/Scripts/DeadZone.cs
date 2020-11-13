using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Cada vez que queramos usar las características de UI se debe colocar su extensión
using UnityEngine.SceneManagement; //Extensión para cargar escenas distintas o volver a cargar la misma escena

public class DeadZone : MonoBehaviour
{
    //Función que detecta el choque con la colisión
    //El nombre de la variable es collision pero puede ser nombrado como uno quiera
    //En algunos casos el nombre de la variable puede ser col u other
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug que imprime un mensaje al darse la acción
        Debug.Log("Colisión");
    }*/

    //Definimos las variables que harán referencia a los objetos texto
    //De esta forma puedan cambiar automáticamente
    public Text scorePlayerText;
    public Text scoreEnemyText;

    //Variables que representen el score del player y el enemigo
    int scorePlayerQuantity;
    int scoreEnemyQuantity;  
                     
    //Función que detecta que el objeto atravesó la colisión
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug que imprime un mensaje al darse la acción
        //Debug.Log("Trigger");

        //Condicional para identificar el tag del objeto que tiene el script asignado
        if (gameObject.tag == "Left") 
        {
            //scoreEnemyQuantity = scoreEnemyQuantity + 1;
            //Forma abreviada de sumar + 1
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        
        }else if (gameObject.CompareTag("Right"))//Otra forma de comparar
        {
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }


    }

    //Creamos una función que reciba dos parametros de tipo texto y numerico
    //Label hace referencia al UI Text al cual le modificaremos su variable texto dentro del componente texto
    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString(); //Al ser una variable texto tenemos que castearlo porque recibe un numerico
    }





}
