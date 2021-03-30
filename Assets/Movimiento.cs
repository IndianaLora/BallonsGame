using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movimiento : MonoBehaviour
{
    Rigidbody2D rb;
    public float Velocidad = 8f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
          //Vector3 DireccionX = Input.GetAxis ("Horizontal") * Vector3.right;
        Vector3 DireccionY = Input.GetAxis ("Vertical") * Vector3.up;


        //Vector3 Direccion = DireccionX + DireccionY;
        Vector3 Direccion = DireccionY;
    
        Vector3 VectorVelocidad = Direccion * Velocidad;

        rb.velocity = VectorVelocidad;

    }

}
