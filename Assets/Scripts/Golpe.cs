using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpe : MonoBehaviour
{
    private BoxCollider2D golpe;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {

        golpe = GetComponent<BoxCollider2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo") && Input.GetKey("space")) 
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(collision.gameObject);
        }
    }
}
