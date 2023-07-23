using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver2 : MonoBehaviour
{
    public float moveSpeed=5f;
    public float rotateSpeed=12f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.forward*rotateSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.H))
        {
             transform.Rotate(Vector3.back*rotateSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.T)){
            transform.Translate(Vector2.up*moveSpeed*Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.B)){
            transform.Translate(Vector2.down*moveSpeed*Time.deltaTime);

        }

    }
}
