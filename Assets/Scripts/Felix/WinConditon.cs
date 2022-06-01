using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinConditon : MonoBehaviour
{
    private float timer = 0;
    public GameObject uWon;
    public GameObject[] win;
    int objCount;  
    void Update()
    {
        foreach (GameObject go in win)
        {
            if (go.activeSelf)
            {
                print("Active " + go.name);
                return;
            }
        }
        print("You won!");
        uWon.SetActive(true);
        timer += Time.deltaTime;
        if(timer >= 7)
        {
            SceneManager.LoadScene("Menu");
        }


    }

}
