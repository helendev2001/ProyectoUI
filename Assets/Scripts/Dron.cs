using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dron : MonoBehaviour
{
    public Animator anim;
    public float vida;
    public static int totalDrones;
    public int dronCount;
    void Start()
    {
        anim.GetComponent<Animator>();
        GameObject[] drones = GameObject.FindGameObjectsWithTag("Obstaculo");

        totalDrones = drones.Length;
        Debug.Log(totalDrones);

    }
    void Update()
    {

    }
    public void getDamage(float golpe)
    {
        vida -= golpe;
        anim.SetTrigger("Golpe");
        if (vida <= 0)
        {
            Destroy(gameObject, 2f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Obstaculo"))
        {

            dronCount = dronCount + 1;

            if (dronCount == totalDrones)
            {
                // Aquí puedes agregar el código para mostrar el cofre
                Debug.Log(dronCount);

            }
        }

    }
}
