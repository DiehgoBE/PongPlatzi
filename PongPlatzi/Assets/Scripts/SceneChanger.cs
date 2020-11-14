using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Extensión para interactuar entre escenas

public class SceneChanger : MonoBehaviour
{
    //Función publica para poder cargar escenas
    //Al ser una función pública se podrá acceder a ella desde el entorno de Unity.
    //La función pide una variable de entrada la cual tambien se podrá acceder desde Unity
    public void ChangeSceneTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);//Cargar escena
    }

}
