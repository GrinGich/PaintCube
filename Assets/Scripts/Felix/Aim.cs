using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Aim : MonoBehaviour
{
    [SerializeField]
    Transform Crosshair;
    Vector3 course;
    Rotation circle;
    bool move = false;
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
            move = true;
        }
        if (move)
        {
            transform.position += course * 6 * Time.deltaTime;
        }


    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        move = false;
        circle.rotate = true;

    }
}
