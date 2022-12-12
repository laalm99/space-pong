using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPhysics : MonoBehaviour
{
    public float amplitude;         
    public float speed;                 
    private float tempVal;
    private Vector3 tempPos;

    void Start()
    {
        tempVal = transform.position.y;
    }

    void Update()
    {
        tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = tempPos;
    }

}
