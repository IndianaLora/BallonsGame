using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] float Speed;

    Rigidbody2D rb;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] Vector3 bulletForce;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }
    }

    private void FixedUpdate()
    {
        //Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        //direction.Normalize();

        //float rotateAmount = Vector3.Cross(direction, transform.right).z;

        //rb.angularVelocity = -rotateAmount * Speed * Time.deltaTime;
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet.GetComponent<Rigidbody2D>().AddTorque(bulletForce.y);

        Destroy(bullet, 3f);
    }
}
