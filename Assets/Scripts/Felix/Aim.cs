using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Aim : MonoBehaviour
{
    [SerializeField]
    Transform Crosshair;
    Vector3 course;
    Rotation circle;
    void Start()
    {
       circle = GameObject.Find("Circle").GetComponent<Rotation>();
    }

    
    void Update()
    {
       course = (Crosshair.position - transform.position).normalized;
       /* while(Input.GetKey(KeyCode.Space))
        {
            circle.rotate = false;
        }*/
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += course * 3 * Time.deltaTime;
        }
        
    }
    
}
