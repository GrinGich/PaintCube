using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoveringButtons : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    [SerializeField] int exitOrLoad;


    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
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
