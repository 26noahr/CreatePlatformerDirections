using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector2.right * speed * Time.deltaTime);

        if (transform.position.x > 4)
            speed = -3; 
        if (transform.position.x < -4)
            speed = 3;
    }
}
