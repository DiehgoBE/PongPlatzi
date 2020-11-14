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

    //Creamos una variable que sea del tipo de dato de nuestro script de cambio de escena
    //De esta forma poder referenciarla desde Unity
    public SceneChanger sceneChanger;
                     
    //Función que detecta que el objeto atravesó la colisión
    private void OnTriggerEnter2D(Collider2D ball)//Variable que choca con el collider
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

        //Cada vez que la pelota pase por el collider Trigger se tiene que reiniciar
        //Por lo tanto se tiene que cambiar el valor de gameStarted a False
        //Podemos usar GetComponent para acceder a los componentes de un game object que sería los mismo que referenciarlos
        //Recuerda que al agregar el scrip a un game object se combierte en un componente que podemos acceder mediante código
        ball.GetComponent<BallBehaviour>().gameStarted = false;

        //Recuerda que crear la función no es suficiente, tenemos que llamarla
        //Puede ser desde el Update o cuando suceda un evento determinado
        CheckScore();

    }

    //Creamos una función que me permita verificar mediante una condicional
    //que la cant. de puntos ya superó el monto para mostrar una escena o no
    void CheckScore()
    {
        if (scorePlayerQuantity >=3)
        {
            //Al crear una variable del tipo de dato del script de cambio de escena
            //podermos ingresar a las funciones definidas dentro de ella
            //De esta forma poder definir que escena mostrar en base a la condicional
            sceneChanger.ChangeSceneTo("WinScene");
        }else if (scoreEnemyQuantity >=3)
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }

    //Creamos una función que reciba dos parametros de tipo texto y numerico
    //Label hace referencia al UI Text al cual le modificaremos su variable texto dentro del componente texto
    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString(); //Al ser una variable texto tenemos que castearlo porque recibe un numerico
    }





}
