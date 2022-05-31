using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Aim : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "wall")
        {
            audioSource.Play();
        }
    }
}
