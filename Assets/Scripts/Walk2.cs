using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk2 : MonoBehaviour
{
    public Transform target;
    public float speed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step=speed*Time.deltaTime;
        transform.position=Vector3.MoveTowards(transform.position,target.position,step);
    }
}
