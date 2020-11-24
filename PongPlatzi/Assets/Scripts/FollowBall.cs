using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{

    //Creamos dos variables pública para el movimiento automático de nuestro enemigo en base a la posición de la pelota
    //Necesitamos la posición de la pelota
    //Procurar usar el tipo de dato más fácil que querramos, en este caso queremos la posición por lo que usamos
    //el tipo de dato Transform
    public Transform ball;

    //Creamos la variable speed para poder ir probando la velocidad de nuestro enemigo desde Unity
    public float speed;

    //No requerimos usar Start
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //Validar si el juego ya inició para que nuestro enemigo siga la pelota de lo contrario no
        if (ball.GetComponent<BallBehaviour>().gameStarted) // Es igual que ball.GetComponent<BallBehaviour>().gameStarted == True
        {
            //Comparar la posición Y de nuestra paleta con la posición Y de nuestra pelota
            //Validar si la posición Y de la paleta es menor a la posición Y de la pelota
            if (transform.position.y < ball.position.y)
            {
                //En caso cumpla la condición entonces aumentar la velocidad de la paleta
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            } else if (transform.position.y > ball.position.y) //Validar si la posición Y de la paleta es mayor a la posición Y de la pelota
            {
                //En caso cumpla la condición entonces restar la velocidad de la paleta
                transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }
        }
    }
}
