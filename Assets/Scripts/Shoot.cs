using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
  
    public GameObject spawn;
    public float speed = 100f;
    private bool exists;
  
    // Update is called once per frame
    void Update()
    {
        //
        if (Input.GetButtonDown("Fire1") &&!GameObject.FindWithTag("Bullet"))
        {
            GameObject inst_bull = Instantiate(bullet, spawn.transform.position, transform.rotation,this.transform) as GameObject;
            Debug.Log(inst_bull.transform.position);
            Rigidbody rb = inst_bull.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * speed);
        }
    }

    
}
