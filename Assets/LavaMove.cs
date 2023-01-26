using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public InGame ig;
    public Camera cam;
    private float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = cam.transform.position.y - transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.transform.position.y - transform.position.y > offset && rb.velocity.y > 0)
            transform.Translate (Time.deltaTime*rb.velocity.y*Vector2.up*1/1);
        else 
            transform.Translate (Time.deltaTime*Vector2.up*1/8);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            ig.loseHealth();
            rb.velocity = new Vector2(0, 12);
        }
    }
}
