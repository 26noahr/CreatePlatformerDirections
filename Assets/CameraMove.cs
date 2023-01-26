using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Rigidbody2D rb;
    //private float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < rb.transform.position.y && rb.velocity.y > 0)
            transform.Translate (Time.deltaTime*rb.velocity.y*Vector2.up*1/1);
    }
}
