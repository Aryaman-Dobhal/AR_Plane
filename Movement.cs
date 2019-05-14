using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Camera camera;
    public float speed;
    // Use this for initialization
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + camera.transform.forward * speed * Time.deltaTime;
        speed = speed + Time.deltaTime;
    }
}
