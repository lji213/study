using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.left * speed * Time.deltaTime;
       Debug.Log(transform.position);
    }
}
