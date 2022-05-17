using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed;
    public bool rotate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
         transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            rotate = false;
        }
    }
}
