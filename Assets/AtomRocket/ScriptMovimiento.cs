using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class ScriptMovimiento : MonoBehaviour
{
    Rigidbody2D rb;
    public float Velocidad = 3f;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] Vector3 bulletForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 DireccionY = Input.GetAxis ("Vertical") * Vector3.up;

        Vector3 Direccion = DireccionY;
        Vector3 VectorVelocidad = Direccion * Velocidad;

        rb.velocity = VectorVelocidad;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(bulletForce);

        Destroy(bullet, 3f);
    }
}
