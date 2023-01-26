using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformOnOff : MonoBehaviour
{
    
    public Rigidbody2D rb;
    Collider2D thisobject;

    // Start is called before the first frame update
    void Start()
    {
        thisobject = GetComponent<Collider2D>();
    }

    // If the Ball is moving up, It can pass through platforms
    void Update()
    {
        if (rb.velocity.y > 0)
            thisobject.enabled = false;
        else
            thisobject.enabled = true;
    }
}
