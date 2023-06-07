using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omnitrix : MonoBehaviour
{
    private BoxCollider2D omnitrix;
    public GameObject obstaculo;
    public Dron listaDron = new Dron();
    

    // Start is called before the first frame update
    void Start()
    {
    

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
       
    }

    //Funciones
    public void collectDrones()
    {
       
    }
}
