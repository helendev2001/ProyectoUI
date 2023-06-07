using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    // Start is called before the first frame update
    public Transform controler;
    public float radio;
    public float golpe;
    public Animator anim;
    public int vida;
    
     void Start()
    {
        anim.GetComponent<Animator>();
        

    }
   void Update()
    {
        if (Input.GetKey("space"))
        {
            anim.SetTrigger("Golpe");
            Collider2D[] drones = Physics2D.OverlapCircleAll(controler.position,radio);
            foreach(Collider2D col in drones)
            {
                if (col.CompareTag("Obstaculo"))
                {
                    col.transform.GetComponent<Dron>().getDamage(golpe);

                }

                    
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controler.position, radio);
    }

}