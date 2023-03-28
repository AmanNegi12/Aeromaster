using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controler();
        Pos();
    }
    void controler()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward*speed*Time.deltaTime);
            transform.Translate(-Vector3.right *10* Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward*speed*Time.deltaTime);
            transform.Translate(Vector3.right *10* Time.deltaTime, Space.World);
        }
    }
    void Pos()
    {
       
    }
}
