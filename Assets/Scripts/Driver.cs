using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float rotateSpeed=1.2f;

    [SerializeField]float moveSpeed=0.06f;
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        float rotateAmount=Input.GetAxis("Horizontal")*rotateSpeed;
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed;
        transform.Rotate(0,0,-rotateAmount);
        transform.Translate(0,moveAmount,0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger");

    }
}