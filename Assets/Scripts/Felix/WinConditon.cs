using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditon : MonoBehaviour
{

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
    }

}
