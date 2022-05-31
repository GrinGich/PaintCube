using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSourceMenu;
    void Start()
    {
            audioSourceMenu.Play();
        
        
    }


    void Update()
    {
        
    }
}
