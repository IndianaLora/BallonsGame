﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBala : MonoBehaviour
{
    public float Velocidad = 30;


    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Velocidad * Time.deltaTime;  
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Puntos"))
    //    {
    //        other.gameObject.SetActive(false);
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Puntos")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
