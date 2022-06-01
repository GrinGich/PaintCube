using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoveringButtons : MonoBehaviour
{
    [SerializeField] int sceneIndex;   // a variable for the scene that will be loaded
    [SerializeField] int exitOrLoad;  //a variable to check which button this script is placed on


    private void OnCollisionEnter2D(Collision2D collision)
    { //on collision it checks what button this is and either loads a scene or exits the game
        if (exitOrLoad == 1)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        if (exitOrLoad==0)
        {
            Application.Quit();
        }
    }
}
