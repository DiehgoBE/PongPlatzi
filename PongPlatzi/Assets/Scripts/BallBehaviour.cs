using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //Creamos una variable publica que referencia la game object Paddle
    //Al ser publica se puede agregar el game object a referenciar desde Unity (Arrastar al componente Script)
    public Transform paddle;

    //Definir si nuestro juego ya ha iniciado
    //False: aún no inicia
    //True: ya inició
    bool gameStarted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!gameStarted) //Si aún no inicia el juego que la pelota siga a la paleta
        {
            //Definir la posición de Ball enfrente de Paddle
            float posDif = paddle.position.x - transform.position.x;

            //Hacemos que la posicion del game object Ball se igual a la posicion del game object Paddle
            //transform.position =paddle.position;

            //Procedemos a restar la posición de nuestro paddle con Ball para que este enfrente de Paddle
            //Se pone automaticamente adelante del Paddle sin importar donde la pongamos
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
            
            //Capturamos cuando se haga un clic en la pantalla para cambiar a verdadero
            //El clic izquierdo es 0
            if (Input.GetMouseButtonDown(0)) 
            {
                gameStarted = true;
            }


        }





    }
}
