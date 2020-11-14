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
    //bool gameStarted = false;

    //Necesitamos acceder a la variable desde otro script por lo que la hacemos publica
    //De esta forma poder reiniciar nuestro juego según las condiciones que definamos
    public bool gameStarted = false;


    //Creamos una variable publica para tener acceso a las caracteristicas de Rigidbody2D
    public Rigidbody2D rbBall;

    //No podemos definir variables dentro de Start porque sino Update no los detecta
    float posDif = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Al tener la diferencia que define el lugar de incio de la pelota en el Update
        //Hace que se coloqué muy lejos de la pelota porque la posición de la pelota ahora es más lejana de la paleta
        //Por lo tanto tenenmos que definirla fuera del Update para que se ejecute una vez en el Start.
        posDif = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!gameStarted) //Si aún no inicia el juego que la pelota siga a la paleta
        {
            //Definir la posición de Ball enfrente de Paddle
            //float posDif = paddle.position.x - transform.position.x;

            //Hacemos que la posicion del game object Ball se igual a la posicion del game object Paddle
            //transform.position =paddle.position;

            //Procedemos a restar la posición de nuestro paddle con Ball para que este enfrente de Paddle
            //Se pone automaticamente adelante del Paddle sin importar donde la pongamos
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
            
            //Capturamos cuando se haga un clic en la pantalla para cambiar a verdadero
            //El clic izquierdo es 0
            if (Input.GetMouseButtonDown(0)) 
            {
                //Damos velocidad al rigidbody de la pelota
                //Dependiendo los valores que se colocan en el vector2 (x,y) será la inclinación del vector
                //Tiene una dirección y una magnitud
                rbBall.velocity = new Vector2(8,8);

                //De esta forma damos inicio al juego
                gameStarted = true;
            }


        }





    }
}
