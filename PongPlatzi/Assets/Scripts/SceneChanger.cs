using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Extensión para interactuar entre escenas

public class SceneChanger : MonoBehaviour
{
    //Función publica para poder cargar escenas
    public void ChangeSceneTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);//Cargar escena
    }

}
